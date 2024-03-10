namespace Redaction
{
    public partial class RegisrtationForm : Form
    {
        public RegisrtationForm()
        {
            InitializeComponent();
        }

        private void RegistrationBT_Click(object sender, EventArgs e)
        {
            RegistrateNewUser();
            CreateFolderForAuthor();
        }
        private void RegistrateNewUser()
        {
            string userLogin = NicOfUserTB.Text;
            string userName = NameOfUser.Text;
            string userSurname = textBox1.Text;
            string userMail = MailTB.Text;
            string userPass = PasswordTB.Text;
            DateTime birthDay = dateTimeOfBirth.Value;
            Role role = ReaderCheckBox.Checked == true ? Role.Reader : Role.Author;
            string userFolder;

            User newUser = new User(userLogin, userName, userSurname, userMail, userPass, birthDay, role);

            UserRegistration.RegisterUser(newUser);
            Form1 autentificateForm = new Form1();
            autentificateForm.Show();
            Close();

        }

        private void CreateFolderForAuthor()
        {
            if (AutorCheckBox.Checked == true)
            {
                string folderPath = Directory.GetCurrentDirectory() + "\\userLogin";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

            }
        }

        private void ReaderCheckBox_CLick(object sender, EventArgs e)
        {
            AutorCheckBox.Checked = false;

        }
        private void AutorCheckBox_Click(object sender, EventArgs e)
        {
            ReaderCheckBox.Checked = false;

        }

        private void checkPassReg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassReg.Checked)
            {
                PasswordTB.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTB.UseSystemPasswordChar = false;
            }
        }

        
    }
}
