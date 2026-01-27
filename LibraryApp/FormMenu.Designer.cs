namespace LibraryApp
{
    partial class FormMenu
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
            pnTop = new Panel();
            btnBack = new Button();
            lblUserName = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            btnBooks = new Button();
            pnTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(btnBack);
            pnTop.Controls.Add(lblUserName);
            pnTop.Controls.Add(btnExit);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Margin = new Padding(4);
            pnTop.Name = "pnTop";
            pnTop.Padding = new Padding(13, 0, 13, 13);
            pnTop.Size = new Size(580, 51);
            pnTop.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(74, 111, 165);
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(13, 0);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 38);
            btnBack.TabIndex = 9;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(372, 0);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "label1";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(74, 111, 165);
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(417, 0);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 38);
            btnExit.TabIndex = 7;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnBooks);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 51);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(580, 352);
            panel1.TabIndex = 3;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.FromArgb(74, 111, 165);
            btnBooks.Dock = DockStyle.Top;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Times New Roman", 12F);
            btnBooks.ForeColor = Color.White;
            btnBooks.Location = new Point(10, 10);
            btnBooks.Margin = new Padding(4);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(560, 50);
            btnBooks.TabIndex = 5;
            btnBooks.Text = "КНИГИ";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += BtnBooks_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(580, 403);
            Controls.Add(panel1);
            Controls.Add(pnTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private Button btnBack;
        private Label lblUserName;
        private Button btnExit;
        private Panel panel1;
        private Button btnBooks;
    }
}