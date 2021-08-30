using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionOn { get; set; }
        public int? CustomerId { get; set; }
        public int? ItemOrderId { get; set; }
        public string TransactionType { get; set; }
        public decimal LastBalance { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public bool IsDelete { get; set; }
        public int FinancialYearId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual ItemOrder ItemOrder { get; set; }
    }
}
