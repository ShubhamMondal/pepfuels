using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IRole
    {
        Task<IEnumerable<Role>> GetList();
        Task<Role> GetById(int id);
        Task save(Role Role);
        Task update(Role Role);
        Task delete(Role Role);
    }
}
