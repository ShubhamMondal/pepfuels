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
    public class SupervisorService : Repository<Supervisor>, ISupervisor
    {
        public SupervisorService(pepfuels_dbContext context)
             : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<Supervisor>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.SupervisorId)
            .ToListAsync();
        }
        public async Task<Supervisor> GetById(int id)
        {
            return await GetByCondition(c => c.SupervisorId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(Supervisor oSupervisor)
        {
            Insert(oSupervisor);
            await SaveAsync();
        }
        public async Task update(Supervisor oSupervisor)
        {
            Update(oSupervisor);
            await SaveAsync();
        }
        public async Task delete(Supervisor oSupervisor)
        {
            Delete(oSupervisor);
            await SaveAsync();
        }
        #endregion
    }
}
