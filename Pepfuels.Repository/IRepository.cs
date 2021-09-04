using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Pepfuels.DAL;

namespace Pepfuels.Repository
{
    public interface IRepository<T>
    {
        T GetFirst();
        IQueryable<T> GetAll();
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveAsync();
    }
}
