namespace Redaction.RoleOrUsers
{
    partial class AdminPanel
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
            UserLB = new ListBox();
            label1 = new Label();
            DataOfUserTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ArticleForAdminTB = new TextBox();
            label4 = new Label();
            label5 = new Label();
            DisplayBT = new Button();
            ListForAdminTV = new TreeView();
            DelArticleBT = new Button();
            SaveChangeBT = new Button();
            AddNewUserBT = new Button();
            DelUserBT = new Button();
            SaveBT = new Button();
            SuspendLayout();
            // 
            // UserLB
            // 
            UserLB.FormattingEnabled = true;
            UserLB.ItemHeight = 15;
            UserLB.Location = new Point(15, 40);
            UserLB.Name = "UserLB";
            UserLB.ScrollAlwaysVisible = true;
            UserLB.Size = new Size(253, 184);
            UserLB.TabIndex = 0;
            UserLB.SelectedIndexChanged += UserLB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 1;
            label1.Text = "Список пользователей";
            // 
            // DataOfUserTB
            // 
            DataOfUserTB.Location = new Point(286, 40);
            DataOfUserTB.Multiline = true;
            DataOfUserTB.Name = "DataOfUserTB";
            DataOfUserTB.ScrollBars = ScrollBars.Vertical;
            DataOfUserTB.Size = new Size(401, 184);
            DataOfUserTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 14);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 3;
            label2.Text = "Данные пользователя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 266);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 7;
            label3.Text = "Список статей и авторов";
            // 
            // ArticleForAdminTB
            // 
            ArticleForAdminTB.Location = new Point(300, 285);
            ArticleForAdminTB.Multiline = true;
            ArticleForAdminTB.Name = "ArticleForAdminTB";
            ArticleForAdminTB.ScrollBars = ScrollBars.Vertical;
            ArticleForAdminTB.Size = new Size(465, 239);
            ArticleForAdminTB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 266);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Статья";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.ForeColor = Color.White;
            label5.Location = new Point(1, 238);
            label5.Name = "label5";
            label5.Size = new Size(915, 10);
            label5.TabIndex = 11;
            // 
            // DisplayBT
            // 
            DisplayBT.Location = new Point(12, 491);
            DisplayBT.Name = "DisplayBT";
            DisplayBT.Size = new Size(256, 33);
            DisplayBT.TabIndex = 12;
            DisplayBT.Text = "Отобразить список";
            DisplayBT.UseVisualStyleBackColor = true;
            DisplayBT.Click += DisplayBT_Click;
            // 
            // ListForAdminTV
            // 
            ListForAdminTV.Location = new Point(12, 285);
            ListForAdminTV.Name = "ListForAdminTV";
            ListForAdminTV.Size = new Size(256, 200);
            ListForAdminTV.TabIndex = 13;
            ListForAdminTV.AfterSelect += ListForAdminTV_AfterSelect;
            // 
            // DelArticleBT
            // 
            DelArticleBT.Location = new Point(792, 285);
            DelArticleBT.Name = "DelArticleBT";
            DelArticleBT.Size = new Size(118, 60);
            DelArticleBT.TabIndex = 14;
            DelArticleBT.Text = "Удалить статью";
            DelArticleBT.UseVisualStyleBackColor = true;
            DelArticleBT.Click += DelArticleBT_Click;
            // 
            // SaveChangeBT
            // 
            SaveChangeBT.Location = new Point(792, 360);
            SaveChangeBT.Name = "SaveChangeBT";
            SaveChangeBT.Size = new Size(118, 57);
            SaveChangeBT.TabIndex = 15;
            SaveChangeBT.Text = "Сохранить изменения";
            SaveChangeBT.UseVisualStyleBackColor = true;
            SaveChangeBT.Click += SaveChangeBT_Click;
            // 
            // AddNewUserBT
            // 
            AddNewUserBT.Location = new Point(721, 40);
            AddNewUserBT.Name = "AddNewUserBT";
            AddNewUserBT.Size = new Size(163, 59);
            AddNewUserBT.TabIndex = 16;
            AddNewUserBT.Text = "Добавить нового пользователя";
            AddNewUserBT.UseVisualStyleBackColor = true;
            AddNewUserBT.Click += AddNewUserBT_Click;
            // 
            // DelUserBT
            // 
            DelUserBT.Location = new Point(721, 171);
            DelUserBT.Name = "DelUserBT";
            DelUserBT.Size = new Size(163, 53);
            DelUserBT.TabIndex = 17;
            DelUserBT.Text = "Удалить пользователя";
            DelUserBT.UseVisualStyleBackColor = true;
            DelUserBT.Click += DelUserBT_Click;
            // 
            // SaveBT
            // 
            SaveBT.Location = new Point(721, 105);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(163, 60);
            SaveBT.TabIndex = 18;
            SaveBT.Text = "Сохранить изменения";
            SaveBT.UseVisualStyleBackColor = true;
            SaveBT.Click += SaveBT_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(922, 536);
            Controls.Add(SaveBT);
            Controls.Add(DelUserBT);
            Controls.Add(AddNewUserBT);
            Controls.Add(SaveChangeBT);
            Controls.Add(DelArticleBT);
            Controls.Add(ListForAdminTV);
            Controls.Add(DisplayBT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ArticleForAdminTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DataOfUserTB);
            Controls.Add(label1);
            Controls.Add(UserLB);
            HelpButton = true;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            FormClosing += AdminPanel_FormClosing;
            Load += AdminPanel_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox DataOfUserTB;
        private Label label2;
        private Label label3;
        private TextBox ArticleForAdminTB;
        private Label label4;
        private Label label5;
        public ListBox UserLB;
        private Button DisplayBT;
        private TreeView ListForAdminTV;
        private Button DelArticleBT;
        private Button SaveChangeBT;
        private Button AddNewUserBT;
        private Button DelUserBT;
        private Button SaveBT;
    }
}