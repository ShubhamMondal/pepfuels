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
    public class ContainerItemService : Repository<ContainerItem>, IContainerItem
    {
        public ContainerItemService(pepfuels_dbContext context)
     : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<ContainerItem>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.ContainerItemId)
            .ToListAsync();
        }
        public async Task<ContainerItem> GetById(int id)
        {
            return await GetByCondition(c => c.ContainerItemId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(ContainerItem oContainerItem)
        {
            Insert(oContainerItem);
            await SaveAsync();
        }
        public async Task update(ContainerItem oContainerItem)
        {
            Update(oContainerItem);
            await SaveAsync();
        }
        public async Task delete(ContainerItem oContainerItem)
        {
            Delete(oContainerItem);
            await SaveAsync();
        }
        #endregion
    }
}
