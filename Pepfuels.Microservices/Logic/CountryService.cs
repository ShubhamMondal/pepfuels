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
    public class CountryService : Repository<Country>, ICountry
    {
        public CountryService(pepfuels_dbContext context)
    : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<Country>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.CountryId)
            .ToListAsync();
        }
        public async Task<Country> GetById(int id)
        {
            return await GetByCondition(c => c.CountryId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(Country oCountry)
        {
            Insert(oCountry);
            await SaveAsync();
        }
        public async Task update(Country oCountry)
        {
            Update(oCountry);
            await SaveAsync();
        }
        public async Task delete(Country oCountry)
        {
            Delete(oCountry);
            await SaveAsync();
        }
        #endregion
    }
}
