namespace Redaction.RoleOrUsers
{
    partial class ReaderPanel
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
            ArticleReaderTB = new TextBox();
            label2 = new Label();
            treeView1 = new TreeView();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // ArticleReaderTB
            // 
            ArticleReaderTB.BackColor = SystemColors.Info;
            ArticleReaderTB.Location = new Point(279, 37);
            ArticleReaderTB.Multiline = true;
            ArticleReaderTB.Name = "ArticleReaderTB";
            ArticleReaderTB.ReadOnly = true;
            ArticleReaderTB.ScrollBars = ScrollBars.Vertical;
            ArticleReaderTB.Size = new Size(369, 421);
            ArticleReaderTB.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(279, 13);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "Статья";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 43);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(246, 360);
            treeView1.TabIndex = 4;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(246, 49);
            button1.TabIndex = 5;
            button1.Text = "Отобразить список";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(187, 21);
            label3.TabIndex = 6;
            label3.Text = "Список авторов и статей";
            // 
            // ReaderPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(660, 470);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Controls.Add(label2);
            Controls.Add(ArticleReaderTB);
            Name = "ReaderPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReaderPanel";
            FormClosing += ReaderPanel_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ArticleReaderTB;
        private Label label2;
        private TreeView treeView1;
        private Button button1;
        private Label label3;
    }
}