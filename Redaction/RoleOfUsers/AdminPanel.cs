using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Redaction.RoleOrUsers
{
    public partial class AdminPanel : Form
    {
        private static List<User>? _userList;
        public AdminPanel()
        {
            InitializeComponent();

            ListForAdminTV.AfterSelect += ListForAdminTV_AfterSelect;

        }


        private void LoadUsersFromJsonFile()
        {
            UserLB.SelectedIndexChanged += UserLB_SelectedIndexChanged;

            string filePath = Directory.GetCurrentDirectory() + "\\user.json";
            if (File.Exists(filePath))
            {
                try
                {
                    // Чтение данных из JSON файла
                    string jsonData = File.ReadAllText(filePath);

                    // Десериализация JSON в список пользователей
                    List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonData);

                    // Очистка списка пользователей перед добавлением новых
                    UserLB.Items.Clear();

                    // Добавление пользователей в UserLB
                    foreach (User user in userList)
                    {
                        UserLB.Items.Add(user.UserName);
                    }

                    MessageBox.Show("Пользователи успешно загружены из файла JSON.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке пользователей из файла JSON: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл JSON не найден по указанному пути.");
            }
        }

        private void AdminPanel_Load_1(object sender, EventArgs e)
        {
            LoadUsersFromJsonFile();
        }

        private void UserLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserLB.SelectedIndex != -1)
            {
                string filePath = Directory.GetCurrentDirectory() + "\\user.json";

                try
                {
                    // Чтение данных из JSON файла
                    string jsonData = File.ReadAllText(filePath);

                    // Десериализация JSON в список пользователей
                    List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonData);

                    // Нахождение выделенного пользователя
                    string selectedUserName = UserLB.SelectedItem.ToString();
                    User selectedUser = userList.Find(u => u.UserName == selectedUserName);

                    // Отображение данных выбранного пользователя в DataOfUserTB
                    if (selectedUser != null)
                    {
                        DataOfUserTB.Text = $"Логин: {selectedUser.UserName}\r\nИмя: {selectedUser.FirstName}\r\nФамилия: {selectedUser.UserName}\r\nEmail: {selectedUser.Email}\r\nПароль: {selectedUser.Password}\r\nДата регистрации: {selectedUser.RegistrrationDate}\r\nДата рождения: {selectedUser.BirthDate}\r\nПуть к папке: {selectedUser.UserFolderPath}\r\nРоль: {selectedUser.Role}\r\nРедактор: {selectedUser.IsRedactor}\r\n";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных пользователя из файла JSON: " + ex.Message);
                }
            }
        }

        private void DisplayBT_Click(object sender, EventArgs e)
        {
            string rootPath = Directory.GetCurrentDirectory() + "\\Авторы\\";
            DirectoryInfo root = new DirectoryInfo(rootPath);
            TreeNode rootTreeNode = new TreeNode(root.Name); // Создание корневого узла

            ListForAdminTV.Nodes.Add(rootTreeNode); // Добавление корневого узла в элемент управления TreeView

            PrintTree(rootTreeNode, root); // Вывод структуры файлов и папок, начиная с корневой директории

            void PrintTree(TreeNode parent, DirectoryInfo directory)
            {
                try
                {
                    DirectoryInfo[] directories = directory.GetDirectories();

                    foreach (DirectoryInfo subDirectory in directories)
                    {
                        TreeNode subDirectoryNode = new TreeNode(subDirectory.Name);
                        parent.Nodes.Add(subDirectoryNode);
                        PrintTree(subDirectoryNode, subDirectory); // Рекурсивный вызов для поддиректорий
                    }

                    FileInfo[] files = directory.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        TreeNode fileNode = new TreeNode(file.Name);
                        parent.Nodes.Add(fileNode);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Обработка ошибок доступа
                    TreeNode errorNode = new TreeNode("Доступ запрещен");
                    parent.Nodes.Add(errorNode);
                }
                catch (Exception ex)
                {
                    // Обработка других ошибок
                    TreeNode errorNode = new TreeNode($"Ошибка: {ex.Message}");
                    parent.Nodes.Add(errorNode);
                }

                DisplayBT.Enabled = false;
            }
        }

        private void ListForAdminTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Проверка, выбран ли узел-файл
            if (selectedNode != null && selectedNode.Nodes.Count == 0)
            {
                // Получение имени файла из узла
                string selectedFileName = selectedNode.Text;

                // Получение полного пути к файлу с использованием Path.Combine
                string selectedFilePath = Path.Combine(Directory.GetCurrentDirectory(), selectedNode.FullPath);

                // Чтение содержимого файла и отображение в ArticleForAdminTB
                try
                {
                    string fileContent = File.ReadAllText(selectedFilePath);
                    ArticleForAdminTB.Text = fileContent;
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при чтении файла
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DelArticleBT_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = ListForAdminTV.SelectedNode;

            if (selectedNode != null && selectedNode.Nodes.Count == 0)
            {
                string selectedFilePath = Path.Combine(Directory.GetCurrentDirectory(), selectedNode.FullPath);

                try
                {
                    // Удаление файла статьи
                    if (File.Exists(selectedFilePath))
                    {
                        File.Delete(selectedFilePath);
                    }

                    // Очистка текстового поля
                    ArticleForAdminTB.Text = string.Empty;

                    // Удаление узла (статьи) из дерева
                    selectedNode.Remove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления файла или узла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveChangeBT_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = ListForAdminTV.SelectedNode;

            if (selectedNode != null && selectedNode.Nodes.Count == 0)
            {
                string selectedFilePath = Path.Combine(Directory.GetCurrentDirectory(), selectedNode.FullPath);

                try
                {
                    // Получение текста из TextBox
                    string newContent = ArticleForAdminTB.Text;

                    // Перезапись содержимого файла
                    File.WriteAllText(selectedFilePath, newContent);

                    MessageBox.Show("Изменения сохранены успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddNewUserBT_Click(object sender, EventArgs e)
        {
            RegisrtationForm registrstion = new RegisrtationForm();
            registrstion.Show();

        }

        private void DelUserBT_Click(object sender, EventArgs e)
        {
            if (UserLB.SelectedIndex != -1)
            {
                string filePath = Directory.GetCurrentDirectory() + "\\user.json";

                try
                {
                    // Чтение данных из JSON файла
                    string jsonData = File.ReadAllText(filePath);

                    // Десериализация JSON в список пользователей
                    List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonData);

                    // Нахождение и удаление выбранного пользователя
                    string selectedUserName = UserLB.SelectedItem.ToString();
                    User selectedUser = userList.Find(u => u.UserName == selectedUserName);
                    userList.Remove(selectedUser);

                    // Сериализация обновленного списка пользователей в JSON и запись в файл
                    string updatedJsonData = JsonConvert.SerializeObject(userList, Formatting.Indented);
                    File.WriteAllText(filePath, updatedJsonData);

                    // Удаление папки пользователя
                    string userFolderPath = Directory.GetCurrentDirectory() + "\\Авторы\\" + selectedUserName;

                    if (Directory.Exists(userFolderPath))
                    {
                        Directory.Delete(userFolderPath, true);
                        MessageBox.Show($"Папка пользователя {selectedUserName} успешно удалена вместе с данными.");
                    }

                    // Очистка текстового блока
                    DataOfUserTB.Text = string.Empty;

                    // Обновление UserLB после удаления
                    UserLB.Items.Clear();
                    foreach (User user in userList)
                    {
                        UserLB.Items.Add(user.UserName);
                    }

                    MessageBox.Show($"Пользователь {selectedUserName} успешно удален и данные сохранены в файле JSON.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении пользователя и сохранении данных в файле JSON: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления.");
            }
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            if (UserLB.SelectedIndex != -1)
            {
                string filePath = Directory.GetCurrentDirectory() + "\\user.json";

                try
                {
                    // Чтение данных из JSON файла
                    string jsonData = File.ReadAllText(filePath);

                    // Десериализация JSON в список пользователей
                    List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonData);

                    // Нахождение выделенного пользователя
                    string selectedUserName = UserLB.SelectedItem.ToString();
                    User selectedUser = userList.Find(u => u.UserName == selectedUserName);

                    // Обновление данных пользователя на основе введенных данных в DataOfUserTB

                    string[] userData = DataOfUserTB.Text.Split('\n');
                    if (userData.Length == 1)
                    {

                        selectedUser.Password = userData[0].Substring(7).Trim();

                    }

                    // Сериализация обновленного списка пользователей в JSON и запись в файл
                    string updatedJsonData = JsonConvert.SerializeObject(userList, Formatting.Indented);
                    File.WriteAllText(filePath, updatedJsonData);

                    MessageBox.Show($"Изменения для пользователя {selectedUserName} успешно сохранены в файле JSON.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении изменений в файле JSON: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для сохранения изменений.");
            }
        }
    }
}
