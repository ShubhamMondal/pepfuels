using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class Supervisor
    {
        public Supervisor()
        {
            ContainerHistories = new HashSet<ContainerHistory>();
        }

        public int SupervisorId { get; set; }
        public string FullName { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Status { get; set; }
        public string IdentityNo { get; set; }
        public string IdentityType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDelete { get; set; }
        public string Landmark { get; set; }
        public string Pincode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<ContainerHistory> ContainerHistories { get; set; }
    }
}
