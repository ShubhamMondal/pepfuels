using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
            Containers = new HashSet<Container>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            Fuels = new HashSet<Fuel>();
            Supervisors = new HashSet<Supervisor>();
        }

        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDelete { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Container> Containers { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<Fuel> Fuels { get; set; }
        public virtual ICollection<Supervisor> Supervisors { get; set; }
    }
}
