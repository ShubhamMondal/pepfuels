using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class ContainerItemService : IContainerItem
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<ContainerItem> containerItemRepository;
        public ContainerItemService(pepfuels_dbContext dbContext,
            IRepository<ContainerItem> ContainerItemRepository)
        {
            this.dbContext = dbContext;
            this.containerItemRepository = ContainerItemRepository;
        }

        #region Get Methods
        public async Task<ContainerItem> GetbyId(int id)
        {
            return await containerItemRepository.GetbyId(id);
        }
        public async Task<IList<ContainerItem>> GetAll()
        {
            return await containerItemRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(ContainerItem oContainerItem)
        {
            await containerItemRepository.Insert(oContainerItem);
        }
        public async Task Update(ContainerItem oContainerItem)
        {
            await containerItemRepository.Update(oContainerItem);
        }
        public async Task Delete(int id)
        {
            await containerItemRepository.Delete(id);
        }
        #endregion
    }
}
