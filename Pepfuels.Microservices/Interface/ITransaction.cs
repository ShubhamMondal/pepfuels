using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface ITransaction
    {
        Task<IEnumerable<Transaction>> GetList();
        Task<Transaction> GetById(int id);
        Task save(Transaction Transaction);
        Task update(Transaction Transaction);
        Task delete(Transaction Transaction);
    }
}
