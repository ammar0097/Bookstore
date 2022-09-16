namespace WebApplication8.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>() {
            new Book
            {
                Id = 1, Title = "c# prog", Description = "no description" 
            },
            new Book
            {
                Id = 2, Title = "php prog", Description = "no description"
            },
            new Book
            {
                Id = 3, Title = "java prog", Description = "no description"
            }
            };
        }
        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = FindById(id);
            books.Remove(book);
        }

        public Book FindById(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id,Book entity)
        {
            var book = FindById(id);
            book.Title = entity.Title;
            book.Description = entity.Description;  
            book.Author = entity.Author; 

        }
    }
}
