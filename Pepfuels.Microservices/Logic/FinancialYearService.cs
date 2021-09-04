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
    public class FinancialYearService : Repository<FinancialYear>, IFinancialYear
    {
        public FinancialYearService(pepfuels_dbContext context)
       : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<FinancialYear>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.FinancialYearId)
            .ToListAsync();
        }
        public async Task<FinancialYear> GetById(int id)
        {
            return await GetByCondition(c => c.FinancialYearId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(FinancialYear oFinancialYear)
        {
            Insert(oFinancialYear);
            await SaveAsync();
        }
        public async Task update(FinancialYear oFinancialYear)
        {
            Update(oFinancialYear);
            await SaveAsync();
        }
        public async Task delete(FinancialYear oFinancialYear)
        {
            Delete(oFinancialYear);
            await SaveAsync();
        }
        #endregion
    }
}
