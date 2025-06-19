using System;

namespace BookLibraryProject
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadDate { get; set; }

        public Book(int id, string title, string author, string genre, int year, bool isRead, DateTime? readDate = null)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            IsRead = isRead;
            ReadDate = isRead ? readDate : null;

        }

        public override string ToString()
        {
            string readMark = IsRead ? $"[✔ {ReadDate?.ToShortDateString()}]" : "[ ]";
            return $"{Id}. {Title} — {Author} ({Genre}, {Year} год) {readMark}";
        }

        // это для txt файла
        public string ToFileString()
        {
            return $"{Id}|{Title}|{Author}|{Genre}|{Year}|{IsRead}|{(ReadDate.HasValue ? ReadDate.Value.ToString("yyyy-MM-dd") : "Н")}";
        }

        // !доделать!
        public static Book FromFileString(string line)
        {
            var parts = line.Split('|');
            int id = int.Parse(parts[0]);
            string title = parts[1];
            string author = parts[2];
            string genre = parts[3];
            int year = int.Parse(parts[4]);
            bool isRead = bool.Parse(parts[5]);
            DateTime? readDate = string.IsNullOrWhiteSpace(parts[6]) ? (DateTime?)null : DateTime.Parse(parts[6]);

            return new Book(id, title, author, genre, year, isRead, readDate);
        }
    }
}
