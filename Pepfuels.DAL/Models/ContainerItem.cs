using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class ContainerItem
    {
        public ContainerItem()
        {
            ContainerHistories = new HashSet<ContainerHistory>();
            ItemOrders = new HashSet<ItemOrder>();
        }

        public int ContainerItemId { get; set; }
        public int FinancialYearId { get; set; }
        public int ContainerId { get; set; }
        public int SerialNo { get; set; }
        public int LitreOcccupied { get; set; }
        public string QrScanGuid { get; set; }
        public string EmbeddedCode { get; set; }
        public string ApiUrl { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDelete { get; set; }

        public virtual Container Container { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual ICollection<ContainerHistory> ContainerHistories { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }
    }
}
