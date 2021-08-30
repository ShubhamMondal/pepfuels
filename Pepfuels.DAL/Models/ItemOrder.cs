using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class ItemOrder
    {
        public ItemOrder()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int ItemOrderId { get; set; }
        public string OrderCode { get; set; }
        public int FinancialYearId { get; set; }
        public int ContainerItemId { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentType { get; set; }
        public string OrderStatus { get; set; }
        public bool IsPaid { get; set; }
        public int CustomerId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal Tax { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string Remarks { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDelete { get; set; }

        public virtual ContainerItem ContainerItem { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
