namespace Redaction
{
    partial class RegisrtationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NicOfUserTB = new TextBox();
            MailTB = new TextBox();
            PasswordTB = new TextBox();
            RegistrationBT = new Button();
            label4 = new Label();
            NameOfUser = new TextBox();
            LastNameTB = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            dateTimeOfBirth = new DateTimePicker();
            AutorCheckBox = new CheckBox();
            ReaderCheckBox = new CheckBox();
            label6 = new Label();
            checkPassReg = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Ник пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 174);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Адрес эл. почты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 227);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // NicOfUserTB
            // 
            NicOfUserTB.Location = new Point(29, 36);
            NicOfUserTB.Multiline = true;
            NicOfUserTB.Name = "NicOfUserTB";
            NicOfUserTB.Size = new Size(251, 30);
            NicOfUserTB.TabIndex = 3;
            // 
            // MailTB
            // 
            MailTB.Location = new Point(29, 192);
            MailTB.Multiline = true;
            MailTB.Name = "MailTB";
            MailTB.Size = new Size(251, 32);
            MailTB.TabIndex = 4;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(29, 245);
            PasswordTB.Multiline = true;
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.Size = new Size(183, 34);
            PasswordTB.TabIndex = 5;
            // 
            // RegistrationBT
            // 
            RegistrationBT.BackColor = Color.PaleGreen;
            RegistrationBT.Location = new Point(129, 356);
            RegistrationBT.Name = "RegistrationBT";
            RegistrationBT.Size = new Size(151, 72);
            RegistrationBT.TabIndex = 6;
            RegistrationBT.Text = "Зарегистрироваться";
            RegistrationBT.UseVisualStyleBackColor = false;
            RegistrationBT.Click += RegistrationBT_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 69);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Имя";
            // 
            // NameOfUser
            // 
            NameOfUser.Location = new Point(29, 87);
            NameOfUser.Multiline = true;
            NameOfUser.Name = "NameOfUser";
            NameOfUser.Size = new Size(251, 32);
            NameOfUser.TabIndex = 8;
            // 
            // LastNameTB
            // 
            LastNameTB.AutoSize = true;
            LastNameTB.Location = new Point(29, 122);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.Size = new Size(58, 15);
            LastNameTB.TabIndex = 9;
            LastNameTB.Text = "Фамилия";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 140);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 32);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 282);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 11;
            label5.Text = "Дата рождения";
            // 
            // dateTimeOfBirth
            // 
            dateTimeOfBirth.Location = new Point(29, 307);
            dateTimeOfBirth.Name = "dateTimeOfBirth";
            dateTimeOfBirth.Size = new Size(251, 23);
            dateTimeOfBirth.TabIndex = 12;
            // 
            // AutorCheckBox
            // 
            AutorCheckBox.AutoSize = true;
            AutorCheckBox.Location = new Point(29, 384);
            AutorCheckBox.Name = "AutorCheckBox";
            AutorCheckBox.Size = new Size(59, 19);
            AutorCheckBox.TabIndex = 13;
            AutorCheckBox.Text = "Автор";
            AutorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReaderCheckBox
            // 
            ReaderCheckBox.AutoSize = true;
            ReaderCheckBox.Location = new Point(29, 409);
            ReaderCheckBox.Name = "ReaderCheckBox";
            ReaderCheckBox.Size = new Size(76, 19);
            ReaderCheckBox.TabIndex = 14;
            ReaderCheckBox.Text = "Читатель";
            ReaderCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 355);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 15;
            label6.Text = "Выберите роль:";
            // 
            // checkPassReg
            // 
            checkPassReg.AutoSize = true;
            checkPassReg.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkPassReg.Location = new Point(231, 245);
            checkPassReg.Name = "checkPassReg";
            checkPassReg.Size = new Size(66, 36);
            checkPassReg.TabIndex = 16;
            checkPassReg.Text = "👀";
            checkPassReg.UseVisualStyleBackColor = true;
            checkPassReg.CheckedChanged += checkPassReg_CheckedChanged;
            // 
            // RegisrtationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(293, 440);
            Controls.Add(checkPassReg);
            Controls.Add(label6);
            Controls.Add(ReaderCheckBox);
            Controls.Add(AutorCheckBox);
            Controls.Add(dateTimeOfBirth);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(LastNameTB);
            Controls.Add(NameOfUser);
            Controls.Add(label4);
            Controls.Add(RegistrationBT);
            Controls.Add(PasswordTB);
            Controls.Add(MailTB);
            Controls.Add(NicOfUserTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisrtationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisrtationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NicOfUserTB;
        private TextBox MailTB;
        private TextBox PasswordTB;
        private Button RegistrationBT;
        private Label label4;
        private TextBox NameOfUser;
        private Label LastNameTB;
        private TextBox textBox1;
        private Label label5;
        private DateTimePicker dateTimeOfBirth;
        private CheckBox AutorCheckBox;
        private CheckBox ReaderCheckBox;
        private Label label6;
        private CheckBox checkPassReg;
    }
}