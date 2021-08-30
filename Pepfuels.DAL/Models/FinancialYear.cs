using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class FinancialYear
    {
        public FinancialYear()
        {
            ContainerItems = new HashSet<ContainerItem>();
            Containers = new HashSet<Container>();
            Customers = new HashSet<Customer>();
            ItemOrders = new HashSet<ItemOrder>();
            Transactions = new HashSet<Transaction>();
        }

        public int FinancialYearId { get; set; }
        public string FinancialYearName { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime EndOn { get; set; }
        public string StartMonth { get; set; }
        public string EndMonth { get; set; }
        public int CurrentYear { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<ContainerItem> ContainerItems { get; set; }
        public virtual ICollection<Container> Containers { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
