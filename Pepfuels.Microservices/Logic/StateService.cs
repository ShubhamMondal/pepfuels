using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class StateService : IState
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<State> stateRepository;
        public StateService(pepfuels_dbContext dbContext,
            IRepository<State> StateRepository)
        {
            this.dbContext = dbContext;
            this.stateRepository = StateRepository;
        }

        #region Get Methods
        public async Task<State> GetbyId(int id)
        {
            return await stateRepository.GetbyId(id);
        }
        public async Task<IList<State>> GetAll()
        {
            return await stateRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(State oState)
        {
            await stateRepository.Insert(oState);
        }
        public async Task Update(State oState)
        {
            await stateRepository.Update(oState);
        }
        public async Task Delete(int id)
        {
            await stateRepository.Delete(id);
        }
        #endregion
    }
}
