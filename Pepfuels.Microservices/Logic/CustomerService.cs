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
    public class CustomerService : Repository<Customer>, ICustomer
    {
        public CustomerService(pepfuels_dbContext context)
        : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<Customer>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.CustomerId)
            .ToListAsync();
        }
        public async Task<Customer> GetById(int id)
        {
            return await GetByCondition(c => c.CustomerId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(Customer oCustomer)
        {
            Insert(oCustomer);
            await SaveAsync();
        }
        public async Task update(Customer oCustomer)
        {
            Update(oCustomer);
            await SaveAsync();
        }
        public async Task delete(Customer oCustomer)
        {
            Delete(oCustomer);
            await SaveAsync();
        }
        #endregion
    }
}
