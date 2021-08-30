using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class ContainerHistory
    {
        public int ContainerHistoryId { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDelete { get; set; }
        public int ContainerId { get; set; }
        public int ContainerItemId { get; set; }
        public int? CustomerId { get; set; }
        public int? SupervisorId { get; set; }

        public virtual Container Container { get; set; }
        public virtual ContainerItem ContainerItem { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}
