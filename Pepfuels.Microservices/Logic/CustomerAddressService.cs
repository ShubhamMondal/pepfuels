using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pepfuels.Microservices.Logic
{
    public class CustomerAddressService : Repository<CustomerAddress>, ICustomerAddress
    {
        public CustomerAddressService(pepfuels_dbContext context)
  : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<CustomerAddress>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.CustomerAddressId)
            .ToListAsync();
        }
        public async Task<CustomerAddress> GetById(int id)
        {
            return await GetByCondition(c => c.CustomerAddressId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(CustomerAddress oCustomerAddress)
        {
            Insert(oCustomerAddress);
            await SaveAsync();
        }
        public async Task update(CustomerAddress oCustomerAddress)
        {
            Update(oCustomerAddress);
            await SaveAsync();
        }
        public async Task delete(CustomerAddress oCustomerAddress)
        {
            Delete(oCustomerAddress);
            await SaveAsync();
        }
        #endregion
    }
}
