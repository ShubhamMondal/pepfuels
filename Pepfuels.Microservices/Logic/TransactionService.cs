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
    public class TransactionService : Repository<Transaction>, ITransaction
    {
        public TransactionService(pepfuels_dbContext context)
            : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<Transaction>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.TransactionId)
            .ToListAsync();
        }
        public async Task<Transaction> GetById(int id)
        {
            return await GetByCondition(c => c.TransactionId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(Transaction oTransaction)
        {
            Insert(oTransaction);
            await SaveAsync();
        }
        public async Task update(Transaction oTransaction)
        {
            Update(oTransaction);
            await SaveAsync();
        }
        public async Task delete(Transaction oTransaction)
        {
            Delete(oTransaction);
            await SaveAsync();
        }
        #endregion
    }
}
