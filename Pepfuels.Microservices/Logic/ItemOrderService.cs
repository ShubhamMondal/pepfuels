using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class ItemOrderService : IItemOrder
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<ItemOrder> itemOrderRepository;
        public ItemOrderService(pepfuels_dbContext dbContext,
            IRepository<ItemOrder> ItemOrderRepository)
        {
            this.dbContext = dbContext;
            this.itemOrderRepository = ItemOrderRepository;
        }

        #region Get Methods
        public async Task<ItemOrder> GetbyId(int id)
        {
            return await itemOrderRepository.GetbyId(id);
        }
        public async Task<IList<ItemOrder>> GetAll()
        {
            return await itemOrderRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(ItemOrder oItemOrder)
        {
            await itemOrderRepository.Insert(oItemOrder);
        }
        public async Task Update(ItemOrder oItemOrder)
        {
            await itemOrderRepository.Update(oItemOrder);
        }
        public async Task Delete(int id)
        {
            await itemOrderRepository.Delete(id);
        }
        #endregion
    }
}
