namespace BooksAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string County { get; set; }
        public string Picture { get; set; }
        public string Publisher { get; set; }
        public string Quality { get; set; }
        public bool Reserved { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int UserId { get; set; }

    }
}
