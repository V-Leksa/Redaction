
namespace Redaction.RoleOrUsers
{
    public partial class ReaderPanel : Form
    {
        public ReaderPanel()
        {
            InitializeComponent();
            treeView1.AfterSelect += treeView1_AfterSelect;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rootPath = Directory.GetCurrentDirectory() + "\\Авторы\\";
            DirectoryInfo root = new DirectoryInfo(rootPath);
            TreeNode rootTreeNode = new TreeNode(root.Name); // Создание корневого узла

            treeView1.Nodes.Add(rootTreeNode); // Добавление корневого узла в элемент управления TreeView

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

                button1.Enabled = false;
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Проверка, выбран ли узел-файл
            if (selectedNode != null && selectedNode.Nodes.Count == 0)
            {
                // Получение имени файла из узла
                string selectedFileName = selectedNode.Text;

                // Получение полного пути к файлу с использованием Path.Combine
                string selectedFilePath = Path.Combine(Directory.GetCurrentDirectory(), selectedNode.FullPath);

                // Чтение содержимого файла и отображение в ArticleReaderTB
                try
                {
                    string fileContent = File.ReadAllText(selectedFilePath);
                    ArticleReaderTB.Text = fileContent;
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при чтении файла
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReaderPanel_FormClosing(object sender, FormClosingEventArgs e)
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
