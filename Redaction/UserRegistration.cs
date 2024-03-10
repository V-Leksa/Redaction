using System.Text.Encodings.Web;
using System.Text.Json;


namespace Redaction
{
     static class UserRegistration
     {
        private static List <User> _users;
        public static void  RegisterUser(User newUser)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\user.json";
            string jsonData = File.ReadAllText(filePath);


            if(jsonData == string.Empty) 
            {
                _users = new List <User> ();
            }
            else
            {
                _users = JsonSerializer.Deserialize<List<User>>(jsonData);
            }
            
            foreach (var user in _users)
            {
                if (user.Email==newUser.Email)
                {
                    MessageBox.Show("Пользователь с такой почтой существует");
                    return;
                }
                else if (user.UserName == newUser.UserName)
                {
                    MessageBox.Show("Такой пользователь существует");
                    return;
                }
            }
             newUser.Id=_users.Count+1;
             newUser.RegistrrationDate=DateTime.Now;
             _users.Add(newUser);

            SerializeUsersToJson(_users, filePath);

            string userFolderPath = Directory.GetCurrentDirectory() + "\\Авторы\\" + newUser.UserName;
            if (!Directory.Exists(userFolderPath))
            {
                Directory.CreateDirectory(userFolderPath);
            }

        }
        public static void SerializeUsersToJson(List<User> users, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string renewedJsonData = JsonSerializer.Serialize(_users, typeof(List<User>), options);

            writer.Write(renewedJsonData);
            writer.Close();
        }
        private static void PasswordEncoder (string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                Console.WriteLine(Convert.ToString(password[i],2));
            }
        }
        

     }
}
