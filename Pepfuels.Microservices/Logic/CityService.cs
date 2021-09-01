using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class CityService : ICity
    {
        private readonly IRepository<City> cityRepository;
        public CityService(IRepository<City> CityRepository)
        {
            this.cityRepository = CityRepository;
        }

        #region Get Methods
        public async Task<City> GetbyId(int id)
        {
            return await cityRepository.GetbyId(id);
        }
        public async Task<IList<City>> GetAll()
        {
            return await cityRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(City oCity)
        {
            await cityRepository.Insert(oCity);
        }
        public async Task Update(City oCity)
        {
            await cityRepository.Update(oCity);
        }
        public async Task Delete(int id)
        {
            await cityRepository.Delete(id);
        }
        #endregion
    }
}
