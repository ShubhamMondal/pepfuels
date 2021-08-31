using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class ConfigureService : IConfigure
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<Configure> configureRepository;
        public ConfigureService(pepfuels_dbContext dbContext,
            IRepository<Configure> ConfigureRepository)
        {
            this.dbContext = dbContext;
            this.configureRepository = ConfigureRepository;
        }

        #region Get Methods
        public async Task<Configure> GetbyId(int id)
        {
            return await configureRepository.GetbyId(id);
        }
        public async Task<IList<Configure>> GetAll()
        {
            return await configureRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(Configure oConfigure)
        {
            await configureRepository.Insert(oConfigure);
        }
        public async Task Update(Configure oConfigure)
        {
            await configureRepository.Update(oConfigure);
        }
        public async Task Delete(int id)
        {
            await configureRepository.Delete(id);
        }
        #endregion
    }
}
