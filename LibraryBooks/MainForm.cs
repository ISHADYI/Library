using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibraryProject
{
    public partial class MainForm : Form
    {
        private Library library = new Library();
        private const string DataFile = "books.txt";
        private List<Book> currentDisplayBooks = new List<Book>();

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            LoadData();
            RefreshList();
        }

        private void InitializeControls()
        {

            // Сортировка
            comboBoxFilters.Items.AddRange(new object[]
            {
                "Все книги",
                "Только прочитанные",
                "Только непрочитанные"
            });
            comboBoxFilters.SelectedIndex = 0;
            comboBoxFilters.SelectedIndexChanged += (s, e) => RefreshList();

            textBoxSearch.TextChanged += (s, e) => RefreshList();
        }

        private void LoadData()
        {
            library.LoadFromFile(DataFile);
        }

        private void RefreshList()
        {
            currentDisplayBooks = library.FilterBooks(
                textBoxSearch.Text,
                comboBoxFilters.SelectedItem?.ToString() ?? "Все книги"
            );
            listBoxBooks.DataSource = currentDisplayBooks;
            listBoxBooks.DisplayMember = "ToString";

            labelStats.Text = $"Прочитано книг: {library.GetReadCount()} из {library.GetTotalCount()}";
        }


        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            var addForm = new AddBookForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var newBook = addForm.NewBook;
                library.AddBook(newBook.Title, newBook.Author, newBook.Genre, newBook.Year, newBook.IsRead, newBook.ReadDate);
                RefreshList();
            }
        }

        private void ButtonToggleRead_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {
                library.ToggleReadStatus(selectedBook.Id);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Выберите книгу из списка для изменения статуса.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            library.SaveToFile(DataFile);
            MessageBox.Show("Данные сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void ButtonDeleteBook_Click(object sender, EventArgs e)
        {

            if (listBoxBooks.SelectedItem == null)
            {
                MessageBox.Show("Выберите книгу для удаления");
                return;
            }

            // Получаем выбранную книгу
            var selectedBook = listBoxBooks.SelectedItem as Book;

            /*if (selectedBook == null)
            {
                MessageBox.Show("Ошибка: выбранный элемент не книга");
                return;
            } */

            // Удаляем книгу из библиотеки по Id
            library.RemoveBook(selectedBook.Id);

            // Обновляем отображение списка книг
            RefreshList();
        }
    }
}
