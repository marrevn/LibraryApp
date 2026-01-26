namespace LibraryApp
{
    partial class FormBooks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnTop = new Panel();
            dgvBooks = new DataGridView();
            btnLogin = new Button();
            lblUserName = new Label();
            button1 = new Button();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(button1);
            pnTop.Controls.Add(lblUserName);
            pnTop.Controls.Add(btnLogin);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(10, 10);
            pnTop.Name = "pnTop";
            pnTop.Padding = new Padding(10, 0, 10, 10);
            pnTop.Size = new Size(964, 40);
            pnTop.TabIndex = 0;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(10, 50);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(964, 601);
            dgvBooks.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(74, 111, 165);
            btnLogin.Dock = DockStyle.Right;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(804, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Выход";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(759, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(74, 111, 165);
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 0);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 9;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 661);
            Controls.Add(dgvBooks);
            Controls.Add(pnTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormBooks";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список книг";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private DataGridView dgvBooks;
        private Label lblUserName;
        private Button btnLogin;
        private Button button1;
    }
}