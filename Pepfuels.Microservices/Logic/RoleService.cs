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
    public class RoleService : Repository<Role>, IRole
    {
        public RoleService(pepfuels_dbContext context) 
            : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<Role>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.RoleId)
            .ToListAsync();
        }
        public async Task<Role> GetById(int id)
        {
            return await GetByCondition(c => c.RoleId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(Role oRole)
        {
            Insert(oRole);
            await SaveAsync();
        }
        public async Task update(Role oRole)
        {
            Update(oRole);
            await SaveAsync();
        }
        public async Task delete(Role oRole)
        {
            Delete(oRole);
            await SaveAsync();
        }
        #endregion
    }
}
