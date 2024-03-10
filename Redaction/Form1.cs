namespace Redaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegistrateBTN_Click(object sender, EventArgs e)
        {
            Hide();
            RegisrtationForm regisrtationForm = new RegisrtationForm();
            regisrtationForm.Show();

        }

        private void EnterBTN_Click(object sender, EventArgs e)
        {
            UserAuthentication authentication = new UserAuthentication();
            authentication.AuthenticateUser(UserLoginTb.Text, UserPasswordTb.Text);

            Hide();

        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                UserPasswordTb.UseSystemPasswordChar = true;
            }
            else
            {
                UserPasswordTb.UseSystemPasswordChar = false;
            }
        }
    }
}