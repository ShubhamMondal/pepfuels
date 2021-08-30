using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Pepfuels.DAL.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Pepfuels.Repository
{
    public class Repository<T> : IRepository<T> where T : DbContext
    {
        private readonly pepfuels_dbContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(pepfuels_dbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public async Task<IList<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> Get(long id)
        {
            return await entities.FindAsync(id);
        }
        public async Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
