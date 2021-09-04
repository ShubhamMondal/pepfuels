using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface ICity
    {
        Task<IEnumerable<City>> GetList();
        Task<City> GetById(int id);
        Task<IEnumerable<City>> getByStateId(int stateId);
        Task save(City city);
        Task update(City city);
        Task delete(City city);
    }
}
