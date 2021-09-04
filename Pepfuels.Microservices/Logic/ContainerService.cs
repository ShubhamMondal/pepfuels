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
    public class ContainerService : Repository<Container>, IContainer
    {
        public ContainerService(pepfuels_dbContext context)
     : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<Container>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.ContainerId)
            .ToListAsync();
        }
        public async Task<Container> GetById(int id)
        {
            return await GetByCondition(c => c.ContainerId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(Container oContainer)
        {
            Insert(oContainer);
            await SaveAsync();
        }
        public async Task update(Container oContainer)
        {
            Update(oContainer);
            await SaveAsync();
        }
        public async Task delete(Container oContainer)
        {
            Delete(oContainer);
            await SaveAsync();
        }
        #endregion
    }
}
