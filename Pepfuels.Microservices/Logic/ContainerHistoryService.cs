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
    public class ContainerHistoryService : Repository<ContainerHistory>, IContainerHistory
    {
        public ContainerHistoryService(pepfuels_dbContext context)
       : base(context)
        {
        }

        #region Get Methods
        public async Task<IEnumerable<ContainerHistory>> GetList()
        {
            return await GetAll()
            .OrderByDescending(ow => ow.ContainerHistoryId)
            .ToListAsync();
        }
        public async Task<ContainerHistory> GetById(int id)
        {
            return await GetByCondition(c => c.ContainerHistoryId.Equals(id))
            .FirstOrDefaultAsync();
        }
        #endregion

        #region Crud Operations
        public async Task save(ContainerHistory oContainerHistory)
        {
            Insert(oContainerHistory);
            await SaveAsync();
        }
        public async Task update(ContainerHistory oContainerHistory)
        {
            Update(oContainerHistory);
            await SaveAsync();
        }
        public async Task delete(ContainerHistory oContainerHistory)
        {
            Delete(oContainerHistory);
            await SaveAsync();
        }
        #endregion
    }
}
