using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
