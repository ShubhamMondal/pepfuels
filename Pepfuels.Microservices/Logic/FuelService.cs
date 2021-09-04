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
    public class FuelService : Repository<Fuel>, IFuel
    {
        public FuelService(pepfuels_dbContext context)
      : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<Fuel>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.FuelId)
            .ToListAsync();
        }
        public async Task<Fuel> GetById(int id)
        {
            return await GetByCondition(c => c.FuelId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(Fuel oFuel)
        {
            Insert(oFuel);
            await SaveAsync();
        }
        public async Task update(Fuel oFuel)
        {
            Update(oFuel);
            await SaveAsync();
        }
        public async Task delete(Fuel oFuel)
        {
            Delete(oFuel);
            await SaveAsync();
        }
        #endregion
    }
}
