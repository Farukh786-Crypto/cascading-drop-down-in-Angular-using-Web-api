using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularWebApi.Entity.Entities
{
    public class CountryMst
    {
        [Key]
        public int countryId { get; set; }

        public string countryName { get; set; }
    }
}
