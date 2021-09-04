using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IConfigure
    {

        Configure GetFirstRow();
        Task save(Configure configure);
        Task update(Configure configure);
        Task delete(Configure configure);
    }
}
