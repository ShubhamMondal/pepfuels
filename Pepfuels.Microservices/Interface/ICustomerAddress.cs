using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface ICustomerAddress
    {
        Task<IEnumerable<CustomerAddress>> GetList();
        Task<CustomerAddress> GetById(int id);
        Task save(CustomerAddress CustomerAddress);
        Task update(CustomerAddress CustomerAddress);
        Task delete(CustomerAddress CustomerAddress);
    }
}
