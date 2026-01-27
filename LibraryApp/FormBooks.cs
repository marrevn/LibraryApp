using LibraryApp.Models;
using LibraryApp.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class FormBooks : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormBooks(User user, bool guest)
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 70;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvBooks.Columns.AddRange(
            [
                colPhoto, colInfo
            ]);
            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.Fio;

            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (var db = new LibDbContext())
                {

                    var books = db.Books
                        .Include(i => i.Avtor)
                        .Include(i=> i.Genre)
                        .Include(i=> i.Publishing)
                         .Include(i => i.BookLoans)
                        .ToList();

                    dgvBooks.SuspendLayout();
                    dgvBooks.Rows.Clear();

                    foreach (var book in books)
                    {
                        int rowIndex = dgvBooks.Rows.Add();
                        var row = dgvBooks.Rows[rowIndex];

                        row.Cells["colPhoto"].Value = LoadBookImage(book.PhotoUrl);

                        row.Cells["colInfo"].Value = FormatBookInfo(book);
                        ApplyRowStyles(row, book);
                    }
                    dgvBooks.ResumeLayout();
                    dgvBooks.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, Book book)
        {
            if (book.CountBook <= 0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFCCCC");
                row.DefaultCellStyle.ForeColor = Color.Black;
                return;
            }
            if (book.CountBook <=2)
            {
                row.DefaultCellStyle.BackColor =
                    ColorTranslator.FromHtml("#FFF3CD");
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            bool hasOverdue = book.BookLoans.Any(l =>
                l.DateReturn == null &&
                l.DateIssuance.AddDays(30) < DateOnly.FromDateTime(DateTime.Now)
            );


            if (hasOverdue)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D4EDDA");
            }
        }

        private string FormatBookInfo(Book book)
        {
            return
                $"ISBN: {book.Isbn}" + Environment.NewLine +
                $"Название: {book.NameBook}" + Environment.NewLine +
                $"Автор: {book.Avtor.AvtorName}" + Environment.NewLine +
                $"Жанр: {book.Genre.GenreName}" + Environment.NewLine +
                $"Издательство: {book.Publishing.PublishName}" + Environment.NewLine +
                $"Год издания: {book.YearIzd}" + Environment.NewLine +
                $"Страниц: {book.Page}" + Environment.NewLine +
                $"Всего экземпляров: {book.Copies}" + Environment.NewLine +
                $"Доступно экземпляров: {book.CountBook}" + Environment.NewLine +
                $"Аннотация:{book.Annotation}";
        }

        private Image LoadBookImage(string photoUrl)
        {
            if (!String.IsNullOrEmpty(photoUrl))
            {
                object obj = Resources.ResourceManager.GetObject(photoUrl);

                if (obj != null)
                {
                    return (Image)obj;
                }
            }

            return Resources.picture;
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
