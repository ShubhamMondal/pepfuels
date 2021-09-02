using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Pepfuels.DAL.Models;
using System.Linq;
using System.Threading.Tasks;
using Pepfuels.Repository.Helpers;

namespace Pepfuels.Repository
{
    public class Repository<T> : IRepository<T> where T : class
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
            return await entities.WhereIsNotDeleted().ToListAsync();
        }

        public async Task<T> GetbyId(int id)
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

        public async Task Delete(int id)
        {
            T entity = await entities.FindAsync(id);
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}
