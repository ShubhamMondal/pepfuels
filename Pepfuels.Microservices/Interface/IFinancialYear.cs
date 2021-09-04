using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IFinancialYear
    {
        Task<IEnumerable<FinancialYear>> GetList();
        Task<FinancialYear> GetById(int id);
        Task save(FinancialYear FinancialYear);
        Task update(FinancialYear FinancialYear);
        Task delete(FinancialYear FinancialYear);
    }
}
