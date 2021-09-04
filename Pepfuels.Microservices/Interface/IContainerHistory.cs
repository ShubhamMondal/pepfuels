using System;
using System.Collections.Generic;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using System.Text;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Interface
{
    public interface IContainerHistory
    {
        Task<IEnumerable<ContainerHistory>> GetList();
        Task<ContainerHistory> GetById(int id);
        Task save(ContainerHistory ContainerHistory);
        Task update(ContainerHistory ContainerHistory);
        Task delete(ContainerHistory ContainerHistory);
    }
}
