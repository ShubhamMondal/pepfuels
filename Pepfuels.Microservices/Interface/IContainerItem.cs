using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IContainerItem
    {
        Task<IEnumerable<ContainerItem>> GetList();
        Task<ContainerItem> GetById(int id);
        Task save(ContainerItem ContainerItem);
        Task update(ContainerItem ContainerItem);
        Task delete(ContainerItem ContainerItem);
    }
}
