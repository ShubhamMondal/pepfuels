using System;
using System.Collections.Generic;
using System.Text;

namespace Pepfuels.DAL.Entity.Models
{
    public class Country_VM
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string IsdCode { get; set; }
        public string RegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public string FlagUrl { get; set; }
    }
}
