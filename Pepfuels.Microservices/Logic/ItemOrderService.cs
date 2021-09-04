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
    public class ItemOrderService : Repository<ItemOrder>, IItemOrder
    {
        public ItemOrderService(pepfuels_dbContext context)
: base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<ItemOrder>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.ItemOrderId)
            .ToListAsync();
        }
        public async Task<ItemOrder> GetById(int id)
        {
            return await GetByCondition(c => c.ItemOrderId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(ItemOrder oItemOrder)
        {
            Insert(oItemOrder);
            await SaveAsync();
        }
        public async Task update(ItemOrder oItemOrder)
        {
            Update(oItemOrder);
            await SaveAsync();
        }
        public async Task delete(ItemOrder oItemOrder)
        {
            Delete(oItemOrder);
            await SaveAsync();
        }
        #endregion
    }
}
