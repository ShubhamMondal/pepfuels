using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class CountryService : ICountry
    {
        private readonly IRepository<Country> countryRepository;
        public CountryService(IRepository<Country> CountryRepository)
        {
            this.countryRepository = CountryRepository;
        }

        #region Get Methods
        public async Task<Country> GetbyId(int id)
        {
            return await countryRepository.GetbyId(id);
        }
        public async Task<IList<Country>> GetAll()
        {
            return await countryRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(Country oCountry)
        {
            await countryRepository.Insert(oCountry);
        }
        public async Task Update(Country oCountry)
        {
            await countryRepository.Update(oCountry);
        }
        public async Task Delete(int id)
        {
            await countryRepository.Delete(id);
        }
        #endregion
    }
}
