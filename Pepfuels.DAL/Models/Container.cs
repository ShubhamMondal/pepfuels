using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class Container
    {
        public Container()
        {
            ContainerHistories = new HashSet<ContainerHistory>();
            ContainerItems = new HashSet<ContainerItem>();
        }

        public int ContainerId { get; set; }
        public int FinancialYearId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string ContainerAddress { get; set; }
        public int ContainerPincode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int TotalCapacity { get; set; }
        public int UsedCapacity { get; set; }
        public int UnusedCapacity { get; set; }
        public decimal TotalLitres { get; set; }
        public decimal OccupiedLitres { get; set; }
        public decimal UnoccupiedLitres { get; set; }
        public string ModelNo { get; set; }
        public DateTime? InstalledOn { get; set; }
        public string EmergencyNo { get; set; }
        public int SupervisorId { get; set; }
        public string Remarks { get; set; }
        public string StatusCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDelete { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<ContainerHistory> ContainerHistories { get; set; }
        public virtual ICollection<ContainerItem> ContainerItems { get; set; }
    }
}
