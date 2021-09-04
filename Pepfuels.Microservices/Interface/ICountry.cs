using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface ICountry
    {
        Task<IEnumerable<Country>> GetList();
        Task<Country> GetById(int id);
        Task save(Country Country);
        Task update(Country Country);
        Task delete(Country Country);
    }
}
