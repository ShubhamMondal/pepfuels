using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface ISupervisor
    {
        Task<IEnumerable<Supervisor>> GetList();
        Task<Supervisor> GetById(int id);
        Task save(Supervisor Supervisor);
        Task update(Supervisor Supervisor);
        Task delete(Supervisor Supervisor);
    }
}
