using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IItemOrder
    {
        Task<IEnumerable<ItemOrder>> GetList();
        Task<ItemOrder> GetById(int id);
        Task save(ItemOrder ItemOrder);
        Task update(ItemOrder ItemOrder);
        Task delete(ItemOrder ItemOrder);
    }
}
