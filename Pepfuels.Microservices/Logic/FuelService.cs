using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class FuelService : IFuel
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<Fuel> fuelRepository;
        public FuelService(pepfuels_dbContext dbContext,
            IRepository<Fuel> FuelRepository)
        {
            this.dbContext = dbContext;
            this.fuelRepository = FuelRepository;
        }

        #region Get Methods
        public async Task<Fuel> GetbyId(int id)
        {
            return await fuelRepository.GetbyId(id);
        }
        public async Task<IList<Fuel>> GetAll()
        {
            return await fuelRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(Fuel oFuel)
        {
            await fuelRepository.Insert(oFuel);
        }
        public async Task Update(Fuel oFuel)
        {
            await fuelRepository.Update(oFuel);
        }
        public async Task Delete(int id)
        {
            await fuelRepository.Delete(id);
        }
        #endregion
    }
}
