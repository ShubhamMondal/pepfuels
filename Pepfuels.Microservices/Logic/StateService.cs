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
    public class StateService : Repository<State>, IState
    {
        public StateService(pepfuels_dbContext context)
            : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<State>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.StateId)
            .ToListAsync();
        }
        public async Task<State> GetById(int id)
        {
            return await GetByCondition(c => c.StateId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(State oState)
        {
            Insert(oState);
            await SaveAsync();
        }
        public async Task update(State oState)
        {
            Update(oState);
            await SaveAsync();
        }
        public async Task delete(State oState)
        {
            Delete(oState);
            await SaveAsync();
        }
        #endregion
    }
}
