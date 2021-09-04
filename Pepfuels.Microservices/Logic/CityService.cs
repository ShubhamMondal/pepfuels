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
    public class CityService : Repository<City>, ICity
    {
        public CityService(pepfuels_dbContext context)
       : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<City>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.CityId)
            .ToListAsync();
        }
        public async Task<City> GetById(int id)
        {
            return await GetByCondition(c => c.CityId.Equals(id))
            .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<City>> getByStateId(int id)
        {
            return await GetByCondition(c => c.StateId.Equals(id))
            .ToListAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(City oCity)
        {
            Insert(oCity);
            await SaveAsync();
        }
        public async Task update(City oCity)
        {
            Update(oCity);
            await SaveAsync();
        }
        public async Task delete(City oCity)
        {
            Delete(oCity);
            await SaveAsync();
        }
        #endregion
    }
}
