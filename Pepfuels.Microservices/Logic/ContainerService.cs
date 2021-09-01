using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class ContainerService : IContainer
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<Container> containerRepository;
        public ContainerService(pepfuels_dbContext dbContext,
            IRepository<Container> ContainerRepository)
        {
            this.dbContext = dbContext;
            this.containerRepository = ContainerRepository;
        }

        #region Get Methods
        public async Task<Container> GetbyId(int id)
        {
            return await containerRepository.GetbyId(id);
        }
        public async Task<IList<Container>> GetAll()
        {
            return await containerRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(Container oContainer)
        {
            await containerRepository.Insert(oContainer);
        }
        public async Task Update(Container oContainer)
        {
            await containerRepository.Update(oContainer);
        }
        public async Task Delete(int id)
        {
            await containerRepository.Delete(id);
        }
        #endregion
    }
}
