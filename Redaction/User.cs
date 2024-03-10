   public enum Role
   {
    Admin,
    Author,
    Reader
   }
namespace Redaction
{
     public class User
     {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SecondtName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrrationDate { get; set; }
        public DateTime BirthDate { get; set; }

        public string UserFolderPath { get; set; }

        public  Role Role { get; set; }
        public bool IsRedactor { get; set; } = false;
        public List<string>ArticleList { get; set; }=new List<string>();

        public User(string userName, string firstName, string secondtName, string email, string password, DateTime birthDate,Role role)
        {
            UserName = userName;
            FirstName = firstName;
            SecondtName = secondtName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Role = role;
            UserFolderPath = Path.Combine(Directory.GetCurrentDirectory() + "\\Авторы\\" + userName);
        }
    }
}
