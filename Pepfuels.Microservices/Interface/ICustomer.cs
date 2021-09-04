using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface ICustomer
    {
        Task<IEnumerable<Customer>> GetList();
        Task<Customer> GetById(int id);
        Task save(Customer Customer);
        Task update(Customer Customer);
        Task delete(Customer Customer);
    }
}
