using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class UserService : IUser
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<User> userRepository;
        public UserService(pepfuels_dbContext dbContext,
            IRepository<User> UserRepository)
        {
            this.dbContext = dbContext;
            this.userRepository = UserRepository;
        }

        #region Get Methods
        public async Task<User> GetbyId(int id)
        {
            return await userRepository.GetbyId(id);
        }
        public async Task<IList<User>> GetAll()
        {
            return await userRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(User oUser)
        {
            await userRepository.Insert(oUser);
        }
        public async Task Update(User oUser)
        {
            await userRepository.Update(oUser);
        }
        public async Task Delete(int id)
        {
            await userRepository.Delete(id);
        }
        #endregion
    }
}
