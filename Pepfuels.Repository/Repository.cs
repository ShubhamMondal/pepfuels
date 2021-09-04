using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Pepfuels.DAL.Models;
using System.Linq;
using System.Threading.Tasks;
using Pepfuels.Repository.Helpers;
using System.Linq.Expressions;

namespace Pepfuels.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected pepfuels_dbContext context { get; set; }
        public Repository(pepfuels_dbContext context)
        {
            this.context = context;
        }
        public T GetFirst()
        {
            return this.context.Set<T>().FirstOrDefault();
        }
        public IQueryable<T> GetAll()
        {
            return this.context.Set<T>().WhereIsNotDeleted().AsNoTracking();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return this.context.Set<T>()
                .Where(expression).AsNoTracking();
        }
        public void Insert(T entity)
        {
            this.context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }
        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
