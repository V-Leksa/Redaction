using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redaction.RoleOrUsers
{
    public partial class AuthorPanel : Form
    {
        public User CurrentUser { get; set; }
        public AuthorPanel(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            LoadUserArticles();
            this.MouseDown += AuthorPanel_MouseDown;
            ArticleListLb.SelectedIndexChanged += ArticleListLb_SelectedIndexChanged;
            
        }

        public void LoadUserArticles()
        {
            // Очистить ListBox перед добавлением новых элементов
            ArticleListLb.Items.Clear();

            // Получить информацию о директории пользователя
            DirectoryInfo userDirectory = new DirectoryInfo(CurrentUser.UserFolderPath);

            // Использовать метод GetFiles для получения файлов в директории
            FileInfo[] files = userDirectory.GetFiles("*.txt");

            if (files.Length > 0)
            {
                // Добавить имена статей в ListBox
                foreach (FileInfo file in files)
                {
                    // Добавить имя файла без расширения
                    ArticleListLb.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                }
            }

        }

        private void DelArticleBt_Click(object sender, EventArgs e)
        {
            if (ArticleListLb.SelectedIndex != -1)
            {
                string selectedArticle = ArticleListLb.SelectedItem.ToString();
                string filePath = Path.Combine(CurrentUser.UserFolderPath, selectedArticle + ".txt");

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                CurrentUser.ArticleList.Remove(selectedArticle);
                ArticleListLb.Items.Remove(selectedArticle);

                ArticleNameTB.Clear();
                ParagraphTextTb.Clear();

                MessageBox.Show("Статья удалена");
            }
            else
            {
                MessageBox.Show("Выберите одну статью для удаления");
            }
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            if (ArticleListLb.SelectedIndex != -1)
            {
                string selectedArticle = ArticleListLb.SelectedItem.ToString();
                string filePath = Path.Combine(CurrentUser.UserFolderPath, selectedArticle + ".txt");

                string paragraphText = ParagraphTextTb.Text;

                // Использование StreamWriter для перезаписи существующего файла
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    sw.Write(paragraphText);
                }

                // Обновление ParagraphTextTb после сохранения изменений
                ParagraphTextTb.Text = paragraphText;

                MessageBox.Show("Изменения сохранены");
            }
            else
            {
                MessageBox.Show("Выберите статью для сохранения изменений");
            }
        }

        private void AddNewArticleBT_Click(object sender, EventArgs e)
        {
            string articleName = ArticleNameTB.Text.Trim();
            string paragraphText = ParagraphTextTb.Text.Trim();

            if (!string.IsNullOrEmpty(articleName) && !string.IsNullOrEmpty(paragraphText))
            {
                string fileName = articleName + ".txt";
                string filePath = Path.Combine(CurrentUser.UserFolderPath, fileName);

                if (File.Exists(filePath))
                {
                    MessageBox.Show("Статья с таким именем уже существует!");
                    return;
                }
                else
                {
                    File.WriteAllText(filePath, paragraphText);

                    CurrentUser.ArticleList.Add(fileName);
                    ArticleListLb.Items.Add(articleName);

                    File.WriteAllText(filePath, paragraphText);

                    ArticleNameTB.Clear();
                    ParagraphTextTb.Clear();

                    MessageBox.Show("Статья успешно создана");
                }

            }
            else
            {
                MessageBox.Show("Название статьи и текст статьи должны быть заполнены!");

            }
        }

        private void ArticleListLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArticleListLb.SelectedIndex != -1)
            {
                string selectedArticle = ArticleListLb.SelectedItem.ToString();
                string filePath = Path.Combine(CurrentUser.UserFolderPath, selectedArticle + ".txt");

                // Проверка, существует ли файл
                if (File.Exists(filePath))
                {
                    // Чтение содержимое файла и отображение его в TextBox
                    string articleContent = File.ReadAllText(filePath);
                    ParagraphTextTb.Text = articleContent;
                }
                else
                {
                    MessageBox.Show("Файл статьи не найден");
                }
            }
        }
        private void AuthorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Очистить выделение в ArticleListLb при клике в любом месте формы
            ArticleListLb.ClearSelected();
            ParagraphTextTb.Clear();
        }

        private void AuthorPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Отменить закрытие формы
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
