using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class FinancialYearService : IFinancialYear
    {
        private readonly pepfuels_dbContext dbContext;
        private readonly IRepository<FinancialYear> financialYearRepository;
        public FinancialYearService(pepfuels_dbContext dbContext,
            IRepository<FinancialYear> FinancialYearRepository)
        {
            this.dbContext = dbContext;
            this.financialYearRepository = FinancialYearRepository;
        }

        #region Get Methods
        public async Task<FinancialYear> GetbyId(int id)
        {
            return await financialYearRepository.GetbyId(id);
        }
        public async Task<IList<FinancialYear>> GetAll()
        {
            return await financialYearRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(FinancialYear oFinancialYear)
        {
            await financialYearRepository.Insert(oFinancialYear);
        }
        public async Task Update(FinancialYear oFinancialYear)
        {
            await financialYearRepository.Update(oFinancialYear);
        }
        public async Task Delete(int id)
        {
            await financialYearRepository.Delete(id);
        }
        #endregion
    }
}
