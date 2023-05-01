using System.Linq.Expressions;

namespace Data.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = "");
        T GetById(int id);
        void Delete(int id);
    }
}
