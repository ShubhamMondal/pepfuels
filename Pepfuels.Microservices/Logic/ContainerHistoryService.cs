using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;

namespace Pepfuels.Microservices.Logic
{
    public class ContainerHistoryService : IContainerHistory
    {
        private readonly IRepository<ContainerHistory> containerHistoryRepository;
        public ContainerHistoryService(IRepository<ContainerHistory> ContainerHistoryRepository)
        {
            this.containerHistoryRepository = ContainerHistoryRepository;
        }

        #region Get Methods
        public async Task<ContainerHistory> GetbyId(int id)
        {
            return await containerHistoryRepository.GetbyId(id);
        }
        public async Task<IList<ContainerHistory>> GetAll()
        {
            return await containerHistoryRepository.GetAll();
        }
        #endregion

        #region Crud Operations
        public async Task Insert(ContainerHistory oContainerHistory)
        {
            await containerHistoryRepository.Insert(oContainerHistory);
        }
        public async Task Update(ContainerHistory oContainerHistory)
        {
            await containerHistoryRepository.Update(oContainerHistory);
        }
        public async Task Delete(int id)
        {
            await containerHistoryRepository.Delete(id);
        }
        #endregion
    }
}
