using Data.Contracts;
using Domain;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : IdentityBase, new()
    {
        private readonly DatabaseContext _db;
        public GenericRepository(DatabaseContext repository)
        {
            _db = repository;
        }
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = "")
        {
            IQueryable<T> query = _db.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            var entity = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var model in entity)
            {
                query = query.Include(model);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return query.ToList();
        }
        public virtual void Delete(int id)
        {
            var entity = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(entity);
        }
        public T GetById(int id)
        {
            return _db.Set<T>().SingleOrDefault(x => x.Id == id);
        }
    }
}
