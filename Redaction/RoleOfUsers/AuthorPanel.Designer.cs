namespace Redaction.RoleOrUsers
{
    partial class AuthorPanel
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
            ArticleNameTB = new TextBox();
            AddNewArticleBT = new Button();
            DelArticleBt = new Button();
            label2 = new Label();
            ArticleListLb = new ListBox();
            label5 = new Label();
            ParagraphTextTb = new TextBox();
            SaveBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Название статьи";
            // 
            // ArticleNameTB
            // 
            ArticleNameTB.Location = new Point(12, 27);
            ArticleNameTB.Multiline = true;
            ArticleNameTB.Name = "ArticleNameTB";
            ArticleNameTB.Size = new Size(218, 27);
            ArticleNameTB.TabIndex = 1;
            // 
            // AddNewArticleBT
            // 
            AddNewArticleBT.Location = new Point(12, 60);
            AddNewArticleBT.Name = "AddNewArticleBT";
            AddNewArticleBT.Size = new Size(218, 28);
            AddNewArticleBT.TabIndex = 2;
            AddNewArticleBT.Text = "Создать статью";
            AddNewArticleBT.UseVisualStyleBackColor = true;
            AddNewArticleBT.Click += AddNewArticleBT_Click;
            // 
            // DelArticleBt
            // 
            DelArticleBt.Location = new Point(12, 450);
            DelArticleBt.Name = "DelArticleBt";
            DelArticleBt.Size = new Size(218, 29);
            DelArticleBt.TabIndex = 3;
            DelArticleBt.Text = "Удалить статью";
            DelArticleBt.UseVisualStyleBackColor = true;
            DelArticleBt.Click += DelArticleBt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Список статей";
            // 
            // ArticleListLb
            // 
            ArticleListLb.FormattingEnabled = true;
            ArticleListLb.ItemHeight = 15;
            ArticleListLb.Location = new Point(12, 156);
            ArticleListLb.Name = "ArticleListLb";
            ArticleListLb.ScrollAlwaysVisible = true;
            ArticleListLb.Size = new Size(218, 289);
            ArticleListLb.TabIndex = 5;
            ArticleListLb.SelectedIndexChanged += ArticleListLb_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 9);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 13;
            label5.Text = "Текст статьи";
            // 
            // ParagraphTextTb
            // 
            ParagraphTextTb.Location = new Point(250, 27);
            ParagraphTextTb.Multiline = true;
            ParagraphTextTb.Name = "ParagraphTextTb";
            ParagraphTextTb.ScrollBars = ScrollBars.Vertical;
            ParagraphTextTb.Size = new Size(465, 452);
            ParagraphTextTb.TabIndex = 14;
            // 
            // SaveBT
            // 
            SaveBT.Location = new Point(12, 94);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(218, 30);
            SaveBT.TabIndex = 15;
            SaveBT.Text = "Сохранить изменения";
            SaveBT.UseVisualStyleBackColor = true;
            SaveBT.Click += SaveBT_Click;
            // 
            // AuthorPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(729, 491);
            Controls.Add(SaveBT);
            Controls.Add(ParagraphTextTb);
            Controls.Add(label5);
            Controls.Add(ArticleListLb);
            Controls.Add(label2);
            Controls.Add(DelArticleBt);
            Controls.Add(AddNewArticleBT);
            Controls.Add(ArticleNameTB);
            Controls.Add(label1);
            Name = "AuthorPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthorPanel";
            FormClosing += AuthorPanel_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ArticleNameTB;
        private Button AddNewArticleBT;
        private Button DelArticleBt;
        private Label label2;
        private ListBox ArticleListLb;
        private Label label5;
        private TextBox ParagraphTextTb;
        private Button SaveBT;
    }
}