using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IState
    {
        Task<IEnumerable<State>> GetList();
        Task<State> GetById(int id);
        Task save(State State);
        Task update(State State);
        Task delete(State State);
    }
}
