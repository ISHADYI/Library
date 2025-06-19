using System;
using System.Collections.Generic;
using System.IO;

namespace BookLibraryProject
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private int nextId = 1;
        public List<Book> Books => books;

        public void AddBook(string title, string author, string genre, int year, bool isRead, DateTime? readDate)
        {
            Book book = new Book(nextId, title, author, genre, year, isRead, readDate);
            nextId++;
            books.Add(book);
        }

        public void ToggleReadStatus(int bookId)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == bookId)
                {
                    books[i].IsRead = !books[i].IsRead;
                    //если теперь книга прочитана, ставим сегодняшнюю дату
                    books[i].ReadDate = books[i].IsRead ? (DateTime?)DateTime.Now : null;
                    break;
                }
            }
        }

        public List<Book> FilterBooks(string searchQuery, string option)
        {
            List<Book> result = new List<Book>();
            // нижний регистр, без пробелов
            string query = (searchQuery ?? "").ToLower().Trim();

            for (int i = 0; i < books.Count; i++)
            {
                Book book = books[i];
                bool matchesQuery = book.Title.ToLower().Contains(query) || book.Author.ToLower().Contains(query);
                bool matchesFilter = true;

                if (option == "Только прочитанные" && !book.IsRead)
                    matchesFilter = false;
                else if (option == "Только непрочитанные" && book.IsRead)
                    matchesFilter = false;

                if (matchesQuery && matchesFilter)
                {
                    result.Add(book);
                }
            }

            return result;
        }

        public int GetReadCount()
        {
            int count = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].IsRead)
                    count++;
            }
            return count;
        }

        public int GetTotalCount()
        {
            return books.Count;
        }

        public void SaveToFile(string path)
        {
            List<string> lines = new List<string>();
            for (int i = 0; i < books.Count; i++)
            {
                lines.Add(books[i].ToFileString());
            }
            File.WriteAllLines(path, lines.ToArray());
        }

        public void LoadFromFile(string path)
        {
            if (!File.Exists(path))
                return;

            books.Clear();
            string[] lines = File.ReadAllLines(path);
            int maxId = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                Book book = Book.FromFileString(lines[i]);
                books.Add(book);
                if (book.Id > maxId)
                    maxId = book.Id;
            }

            nextId = maxId + 1;
        }

        public void RemoveBook(int id)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == id)
                {
                    books.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
