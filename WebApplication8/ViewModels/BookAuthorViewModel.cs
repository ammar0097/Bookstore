using WebApplication8.Models;

namespace WebApplication8.ViewModels
{
    public class BookAuthorViewModel
    {
        public int BookId { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public List<Author> Authors { get; set; }
    }
}
