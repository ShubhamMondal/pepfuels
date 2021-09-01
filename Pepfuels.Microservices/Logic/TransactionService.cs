using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class TransactionService : ITransaction
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<Transaction> transactionRepository;
        public TransactionService(pepfuels_dbContext dbContext,
            IRepository<Transaction> TransactionRepository)
        {
            this.dbContext = dbContext;
            this.transactionRepository = TransactionRepository;
        }

        #region Get Methods
        public async Task<Transaction> GetbyId(int id)
        {
            return await transactionRepository.GetbyId(id);
        }
        public async Task<IList<Transaction>> GetAll()
        {
            return await transactionRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(Transaction oTransaction)
        {
            await transactionRepository.Insert(oTransaction);
        }
        public async Task Update(Transaction oTransaction)
        {
            await transactionRepository.Update(oTransaction);
        }
        public async Task Delete(int id)
        {
            await transactionRepository.Delete(id);
        }
        #endregion
    }
}
