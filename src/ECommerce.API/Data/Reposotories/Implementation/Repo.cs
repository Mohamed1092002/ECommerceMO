using ECommerce.API.Data.Reposotories.Abstract;

namespace ECommerce.API.Data.Reposotories.Implementation
{
    
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly ECommerceDbContext _context;
        public Repo(ECommerceDbContext context)
        {
            _context=context;
        }
        public void Create(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Update(T item)
        {
            _context.Set<T>().Update(item);
        }
    }
}
