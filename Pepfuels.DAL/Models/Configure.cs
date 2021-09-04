using System;
using System.Collections.Generic;

#nullable disable

namespace Pepfuels.DAL.Models
{
    public partial class Configure
    {
        public int ConfigureId { get; set; }
        public decimal? SecurityAmount { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string GoogleLocationApiKey { get; set; }
    }
}
