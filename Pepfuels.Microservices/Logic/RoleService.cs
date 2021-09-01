using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class RoleService : IRole
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<Role> roleRepository;
        public RoleService(pepfuels_dbContext dbContext,
            IRepository<Role> RoleRepository)
        {
            this.dbContext = dbContext;
            this.roleRepository = RoleRepository;
        }

        #region Get Methods
        public async Task<Role> GetbyId(int id)
        {
            return await roleRepository.GetbyId(id);
        }
        public async Task<IList<Role>> GetAll()
        {
            return await roleRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(Role oRole)
        {
            await roleRepository.Insert(oRole);
        }
        public async Task Update(Role oRole)
        {
            await roleRepository.Update(oRole);
        }
        public async Task Delete(int id)
        {
            await roleRepository.Delete(id);
        }
        #endregion
    }
}
