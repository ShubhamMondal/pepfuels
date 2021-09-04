using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IFuel
    {
        Task<IEnumerable<Fuel>> GetList();
        Task<Fuel> GetById(int id);
        Task save(Fuel Fuel);
        Task update(Fuel Fuel);
        Task delete(Fuel Fuel);
    }
}
