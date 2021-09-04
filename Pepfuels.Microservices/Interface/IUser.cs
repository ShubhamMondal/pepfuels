using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IUser
    {
        Task<IEnumerable<User>> GetList();
        Task<User> GetById(int id);
        Task save(User User);
        Task update(User User);
        Task delete(User User);
    }
}
