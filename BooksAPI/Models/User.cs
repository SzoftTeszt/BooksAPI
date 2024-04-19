using Microsoft.Extensions.Hosting;

namespace BooksAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public ICollection<Book> Book { get; } = new List<Book>();

    }
}
