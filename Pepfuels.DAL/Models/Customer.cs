using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            ContainerHistories = new HashSet<ContainerHistory>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            ItemOrders = new HashSet<ItemOrder>();
            Transactions = new HashSet<Transaction>();
        }

        public int CustomerId { get; set; }
        public int FinancialYearId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public bool IsMobileVerified { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsSecurityPaid { get; set; }
        public DateTime? SecurityPaidOn { get; set; }
        public DateTime? SecurityRefundOn { get; set; }
        public int? LastOrderId { get; set; }
        public int? Otp { get; set; }
        public string EmaiToken { get; set; }
        public DateTime? ExpirationTime { get; set; }
        public string Status { get; set; }
        public bool HasContainer { get; set; }
        public DateTime LastLogin { get; set; }
        public string IpAddress { get; set; }
        public string DeviceInfo { get; set; }
        public string IdentityNo { get; set; }
        public string IdentityType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDelete { get; set; }

        public virtual FinancialYear FinancialYear { get; set; }
        public virtual ICollection<ContainerHistory> ContainerHistories { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
