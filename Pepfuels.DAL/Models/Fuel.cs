using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class Fuel
    {
        public int FuelId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public decimal FuelPrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDelete { get; set; }

        public virtual City City { get; set; }
        public virtual State State { get; set; }
    }
}
