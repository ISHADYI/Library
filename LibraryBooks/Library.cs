using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BookLibraryProject
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private int nextId = 1;

        public List<Book> Books => books;

        public void AddBook(string title, string author, string genre, int year, bool isRead, DateTime? readDate)
        {
            var book = new Book(nextId++, title, author, genre, year, isRead, readDate);
            books.Add(book);
        }

        public void ToggleReadStatus(int bookId)
        {
            var book = books.FirstOrDefault(b => b.Id == bookId);
            if (book != null)
            {
                book.IsRead = !book.IsRead;
                book.ReadDate = book.IsRead ? (DateTime?)DateTime.Now : null;
            }
        }

        public List<Book> FilterBooks(string searchQuery, string option)
        {
            searchQuery = searchQuery?.ToLower().Trim() ?? "";
            IEnumerable<Book> filtered = books;

            // Фильтрация по тексту
            if (!string.IsNullOrEmpty(searchQuery))
            {
                filtered = filtered.Where(b =>
                    b.Title.ToLower().Contains(searchQuery) ||
                    b.Author.ToLower().Contains(searchQuery)
                );
            }

            // Фильтрация по статусу
            if (option == "Только прочитанные")
                filtered = filtered.Where(b => b.IsRead);
            else if (option == "Только непрочитанные")
                filtered = filtered.Where(b => !b.IsRead);
            return filtered.ToList();
        }

        public int GetReadCount() => books.Count(b => b.IsRead);

        public int GetTotalCount() => books.Count;

        public void SaveToFile(string path)
        {
            var lines = books.Select(b => b.ToFileString());
            File.WriteAllLines(path, lines);
        }

        public void LoadFromFile(string path)
        {
            if (!File.Exists(path))
                return;

            books.Clear();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var book = Book.FromFileString(line);
                books.Add(book);
            }
            nextId = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
        }

        public void RemoveBook(int id)
        {
            var bookToRemove = books.FirstOrDefault(b => b.Id == id);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }
    }
}
