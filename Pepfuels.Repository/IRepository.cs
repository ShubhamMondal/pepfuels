using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pepfuels.DAL;

namespace Pepfuels.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAll();
        Task<T> GetbyId(int id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
