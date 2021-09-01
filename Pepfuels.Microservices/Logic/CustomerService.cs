using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class CustomerService : ICustomer
    {
        private readonly IRepository<Customer> customerRepository;
        public CustomerService(IRepository<Customer> CustomerRepository)
        {
            this.customerRepository = CustomerRepository;
        }

        #region Get Methods
        public async Task<Customer> GetbyId(int id)
        {
            return await customerRepository.GetbyId(id);
        }
        public async Task<IList<Customer>> GetAll()
        {
            return await customerRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(Customer oCustomer)
        {
            await customerRepository.Insert(oCustomer);
        }
        public async Task Update(Customer oCustomer)
        {
            await customerRepository.Update(oCustomer);
        }
        public async Task Delete(int id)
        {
            await customerRepository.Delete(id);
        }
        #endregion
    }
}
