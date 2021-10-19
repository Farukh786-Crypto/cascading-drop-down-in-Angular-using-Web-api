using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularWebApi.Entity.Entities
{
    public class StateMst
    {
        [Key]
        public int stateId { get; set; }
        public string stateName { get; set; }
        
        // step 1 : to create foreign key create object of class 
        public CountryMst countryMst { get; set; }

        // step 2 : objectname + name of property Ex : below countryMst is object of class
        // and Id is name so sum is i.e countryMstId 
        public int countryMstId { get; set; }

    }
}
