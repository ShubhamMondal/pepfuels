using System;
using System.Collections.Generic;
using System.Text;
using Pepfuels.DAL.Models;
using Pepfuels.Repository;
using Pepfuels.Microservices.Interface;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pepfuels.Microservices.Logic
{
    public class ConfigureService : Repository<Configure>, IConfigure
    {
        public ConfigureService(pepfuels_dbContext context)
        : base(context)
        {
        }

        #region Get Methods
        public Configure GetFirstRow()
        {
            return GetFirst();
        }
        #endregion

        #region Crud Operations
        public async Task save(Configure oConfigure)
        {
            Insert(oConfigure);
            await SaveAsync();
        }
        public async Task update(Configure oConfigure)
        {
            Update(oConfigure);
            await SaveAsync();
        }
        public async Task delete(Configure oConfigure)
        {
            Delete(oConfigure);
            await SaveAsync();
        }
        #endregion
    }
}
