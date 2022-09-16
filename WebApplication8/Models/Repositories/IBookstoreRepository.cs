namespace WebApplication8.Models.Repositories
{
    public interface IBookstoreRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity FindById(int id);
        void Add(TEntity entity);
        void Update(int id ,TEntity entity);
        void Delete(int id);



    }
}
