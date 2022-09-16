using static System.Reflection.Metadata.BlobBuilder;

namespace WebApplication8.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Author>
    {
        List<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author
                {
                    Id = 1, Name = "Ammar"
                },
                 new Author
                {
                    Id = 2, Name = "Ahmed"
                }
            };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = FindById(id);
            authors.Remove(author); 
        }

        public Author FindById(int id)
        {
            var author = authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author entity)
        {
            var author = FindById(id);
            author.Name = entity.Name;
        }
    }
}
