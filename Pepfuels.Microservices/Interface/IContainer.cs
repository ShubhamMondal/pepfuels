using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IContainer
    {
        Task<IEnumerable<Container>> GetList();
        Task<Container> GetById(int id);
        Task save(Container Container);
        Task update(Container Container);
        Task delete(Container Container);
    }
}
