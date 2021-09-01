using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class CustomerAddressService : ICustomerAddress
    {
        private readonly IRepository<CustomerAddress> customerAddressRepository;
        public CustomerAddressService(IRepository<CustomerAddress> CustomerAddressRepository)
        {
            this.customerAddressRepository = CustomerAddressRepository;
        }

        #region Get Methods
        public async Task<CustomerAddress> GetbyId(int id)
        {
            return await customerAddressRepository.GetbyId(id);
        }
        public async Task<IList<CustomerAddress>> GetAll()
        {
            return await customerAddressRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(CustomerAddress oCustomerAddress)
        {
            await customerAddressRepository.Insert(oCustomerAddress);
        }
        public async Task Update(CustomerAddress oCustomerAddress)
        {
            await customerAddressRepository.Update(oCustomerAddress);
        }
        public async Task Delete(int id)
        {
            await customerAddressRepository.Delete(id);
        }
        #endregion
    }
}
