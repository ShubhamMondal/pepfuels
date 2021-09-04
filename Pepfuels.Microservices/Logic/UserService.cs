using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pepfuels.Microservices.Logic
{
    public class UserService : Repository<User>, IUser
    {
        public UserService(pepfuels_dbContext context)
          : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<User>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.UserId)
            .ToListAsync();
        }
        public async Task<User> GetById(int id)
        {
            return await GetByCondition(c => c.UserId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(User oTransaction)
        {
            Insert(oTransaction);
            await SaveAsync();
        }
        public async Task update(User oTransaction)
        {
            Update(oTransaction);
            await SaveAsync();
        }
        public async Task delete(User oTransaction)
        {
            Delete(oTransaction);
            await SaveAsync();
        }
        #endregion
    }
}
