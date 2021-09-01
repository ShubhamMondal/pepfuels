using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class SupervisorService : ISupervisor
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<Supervisor> supervisorRepository;
        public SupervisorService(pepfuels_dbContext dbContext,
            IRepository<Supervisor> SupervisorRepository)
        {
            this.dbContext = dbContext;
            this.supervisorRepository = SupervisorRepository;
        }

        #region Get Methods
        public async Task<Supervisor> GetbyId(int id)
        {
            return await supervisorRepository.GetbyId(id);
        }
        public async Task<IList<Supervisor>> GetAll()
        {
            return await supervisorRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(Supervisor oSupervisor)
        {
            await supervisorRepository.Insert(oSupervisor);
        }
        public async Task Update(Supervisor oSupervisor)
        {
            await supervisorRepository.Update(oSupervisor);
        }
        public async Task Delete(int id)
        {
            await supervisorRepository.Delete(id);
        }
        #endregion
    }
}
