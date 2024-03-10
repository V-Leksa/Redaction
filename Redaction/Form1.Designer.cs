namespace Redaction
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            UserLoginTb = new TextBox();
            label2 = new Label();
            UserPasswordTb = new TextBox();
            EnterBTN = new Button();
            label3 = new Label();
            RegistrateBTN = new Button();
            checkPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин пользователя";
            // 
            // UserLoginTb
            // 
            UserLoginTb.Location = new Point(12, 27);
            UserLoginTb.Multiline = true;
            UserLoginTb.Name = "UserLoginTb";
            UserLoginTb.Size = new Size(409, 23);
            UserLoginTb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 2;
            label2.Text = "Пароль пользователя";
            // 
            // UserPasswordTb
            // 
            UserPasswordTb.Location = new Point(12, 80);
            UserPasswordTb.Multiline = true;
            UserPasswordTb.Name = "UserPasswordTb";
            UserPasswordTb.PasswordChar = '*';
            UserPasswordTb.Size = new Size(300, 23);
            UserPasswordTb.TabIndex = 3;
            // 
            // EnterBTN
            // 
            EnterBTN.BackColor = SystemColors.ControlLight;
            EnterBTN.Location = new Point(323, 134);
            EnterBTN.Name = "EnterBTN";
            EnterBTN.Size = new Size(107, 41);
            EnterBTN.TabIndex = 4;
            EnterBTN.Text = "Войти";
            EnterBTN.UseVisualStyleBackColor = false;
            EnterBTN.Click += EnterBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 5;
            label3.Text = "Еще не зарегистрированы?";
            // 
            // RegistrateBTN
            // 
            RegistrateBTN.BackColor = SystemColors.ControlLight;
            RegistrateBTN.Location = new Point(12, 152);
            RegistrateBTN.Name = "RegistrateBTN";
            RegistrateBTN.Size = new Size(149, 23);
            RegistrateBTN.TabIndex = 6;
            RegistrateBTN.Text = "Зарегистрироваться";
            RegistrateBTN.UseVisualStyleBackColor = false;
            RegistrateBTN.Click += RegistrateBTN_Click;
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkPass.Location = new Point(348, 64);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(73, 41);
            checkPass.TabIndex = 7;
            checkPass.Text = "👀";
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(433, 181);
            Controls.Add(checkPass);
            Controls.Add(RegistrateBTN);
            Controls.Add(label3);
            Controls.Add(EnterBTN);
            Controls.Add(UserPasswordTb);
            Controls.Add(label2);
            Controls.Add(UserLoginTb);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UserLoginTb;
        private Label label2;
        private TextBox UserPasswordTb;
        private Button EnterBTN;
        private Label label3;
        private Button RegistrateBTN;
        private CheckBox checkPass;
    }
}