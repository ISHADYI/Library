using System;
using System.Windows.Forms;

namespace BookLibraryProject
{
    public partial class AddBookForm : Form
    {
        public Book NewBook { get; private set; }

        public AddBookForm()
        {
            InitializeComponent();

            // Ограничение даты прочтения
            dateTimePickerReadDate.MaxDate = DateTime.Today;
            dateTimePickerReadDate.Enabled = false;
            checkBoxIsRead.CheckedChanged += CheckBoxIsRead_CheckedChanged;

            // Настройка даты написания книги
            numericUpDownYear.Minimum = 1000;
            numericUpDownYear.Maximum = DateTime.Now.Year;
            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownYear.Increment = 1;
            numericUpDownYear.ThousandsSeparator = false;

            comboBoxGenre.Items.AddRange(new string[]
            {
                "Фэнтези",
                "Научная фантастика",
                "Детектив",
                "Роман",
                "История",
                "Научно-популярная",
                "Приключения",
                "Биография",
                "Комедия",
                "Ужасы",
                "Другое"
            });
            comboBoxGenre.SelectedIndex = 0;
        }

        private void CheckBoxIsRead_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerReadDate.Enabled = checkBoxIsRead.Checked;
            if (!checkBoxIsRead.Checked)
                dateTimePickerReadDate.Value = DateTime.Now;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text.Trim();
            string author = textBoxAuthor.Text.Trim();
            string genre = comboBoxGenre.SelectedItem?.ToString() ?? "";
            int year = (int)numericUpDownYear.Value;
            bool isRead = checkBoxIsRead.Checked;
            DateTime? readDate = isRead ? (DateTime?)dateTimePickerReadDate.Value.Date : null;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Пожалуйста, заполните все поля: название, автор и жанр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewBook = new Book(0, title, author, genre, year, isRead, readDate);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
