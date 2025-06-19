namespace BookLibraryProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonToggleRead = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStats = new System.Windows.Forms.Label();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonDeleteBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 20;
            this.listBoxBooks.Location = new System.Drawing.Point(12, 234);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(586, 144);
            this.listBoxBooks.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(328, 135);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(270, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(107)))), ((int)(((byte)(87)))));
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(180)))));
            this.buttonAddBook.Location = new System.Drawing.Point(12, 388);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(180, 40);
            this.buttonAddBook.TabIndex = 5;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // buttonToggleRead
            // 
            this.buttonToggleRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(107)))), ((int)(((byte)(87)))));
            this.buttonToggleRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToggleRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(180)))));
            this.buttonToggleRead.Location = new System.Drawing.Point(217, 388);
            this.buttonToggleRead.Name = "buttonToggleRead";
            this.buttonToggleRead.Size = new System.Drawing.Size(180, 40);
            this.buttonToggleRead.TabIndex = 6;
            this.buttonToggleRead.Text = "Прочитано";
            this.buttonToggleRead.UseVisualStyleBackColor = false;
            this.buttonToggleRead.Click += new System.EventHandler(this.ButtonToggleRead_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(107)))), ((int)(((byte)(87)))));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(180)))));
            this.buttonSave.Location = new System.Drawing.Point(418, 446);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 40);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStats.Location = new System.Drawing.Point(12, 520);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(99, 20);
            this.labelStats.TabIndex = 8;
            this.labelStats.Text = "Статистика";
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Font = new System.Drawing.Font("RAYDIS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(107)))), ((int)(((byte)(87)))));
            this.labelMainTitle.Location = new System.Drawing.Point(128, 28);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(364, 43);
            this.labelMainTitle.TabIndex = 9;
            this.labelMainTitle.Text = "Библиотека";
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(12, 135);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(245, 21);
            this.comboBoxFilters.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RAYDIS", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(107)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фильтры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RAYDIS", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(107)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(324, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RAYDIS", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(107)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(11, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Список книг";
            // 
            // ButtonDeleteBook
            // 
            this.ButtonDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(107)))), ((int)(((byte)(87)))));
            this.ButtonDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDeleteBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(180)))));
            this.ButtonDeleteBook.Location = new System.Drawing.Point(418, 388);
            this.ButtonDeleteBook.Name = "ButtonDeleteBook";
            this.ButtonDeleteBook.Size = new System.Drawing.Size(180, 40);
            this.ButtonDeleteBook.TabIndex = 14;
            this.ButtonDeleteBook.Text = "Удалить книгу";
            this.ButtonDeleteBook.UseVisualStyleBackColor = false;
            this.ButtonDeleteBook.Click += new System.EventHandler(this.ButtonDeleteBook_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(610, 549);
            this.Controls.Add(this.ButtonDeleteBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.labelMainTitle);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonToggleRead);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxBooks);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonToggleRead;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonDeleteBook;
    }
}

