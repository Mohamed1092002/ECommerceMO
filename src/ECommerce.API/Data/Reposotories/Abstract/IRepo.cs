namespace ECommerce.API.Data.Reposotories.Abstract
{
    public interface IRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        IQueryable<T> GetQueryable();
    }
}
