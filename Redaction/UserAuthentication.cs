using Redaction.RoleOrUsers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Redaction
{
    public class UserAuthentication
    {
        public void AuthenticateUser(string userLogin, string userPassword)
        {
            StreamReader reader = new StreamReader("user.json");
            string jsonData = reader.ReadToEnd(); ;
            User[] users = JsonSerializer.Deserialize<User[]>(jsonData) ?? throw new Exception("нет данных");

            reader.Close();

            User? currentUser=null;

            EncryptJSON("user.json", "encrypted.json");
            DecryptJSON("encrypted.json", "decrypted.json");

            foreach (User user in users)
            {
                if(user.UserName == userLogin && user.Password==userPassword)
                {
                    currentUser = user;
                }
                
            }
            if(currentUser == null)
            {
                MessageBox.Show("Пользователь не найден или пароль неверен");
                return;
            }

            IsUserAuthenticated(currentUser);

        }
        private void IsUserAuthenticated(User currentUser)
        {
            switch (currentUser.Role)
            {
                case Role.Admin:
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                    break;

                case Role.Reader:
                    ReaderPanel reader = new ReaderPanel();
                    reader.Show();
                    break;

                case Role.Author:
                    AuthorPanel author = new AuthorPanel(currentUser);
                    author.Show();
                    break;

                default:
                break;
            }
            
        }
        
        static string key = "1234567890123456"; //  ключ 

        static void EncryptJSON(string inputFilePath, string outputFilePath)
        {
            string inputFilePat = Directory.GetCurrentDirectory() + "\\user.json";
            string outputFilePat = Directory.GetCurrentDirectory() + "\\encrypted.json";
            try
            {
                string jsonData = File.ReadAllText(inputFilePath);
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = aesAlg.Key.Take(16).ToArray(); // Использование первыч 16 байт от ключа в качестве IV

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (FileStream outputFile = new FileStream(outputFilePath, FileMode.Create))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputFile, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(cryptoStream))
                            {
                                swEncrypt.Write(jsonData);
                            }
                        }
                    }
                }

                MessageBox.Show("Файл успешно зашифрован.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при шифровании файла: {ex.Message}");
            }
        }

        static void DecryptJSON(string inputFilePath, string outputFilePath)
        {
            try
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = aesAlg.Key.Take(16).ToArray();

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (FileStream inputFile = new FileStream(inputFilePath, FileMode.Open))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(inputFile, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(cryptoStream))
                            {
                                string decryptedData = srDecrypt.ReadToEnd();
                                File.WriteAllText(outputFilePath, decryptedData);
                            }
                        }
                    }
                }

                MessageBox.Show("Файл успешно расшифрован.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расшифровке файла: {ex.Message}");
            }
        }
    }
}
