using AngularWebApi.Entity.Entities;
using AngularWebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AngularWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasCadingDDLController : ControllerBase
    {
        private readonly DatabaseContext databaseContext;

        public CasCadingDDLController(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        [HttpGet("GetAllCountry")]
        public ActionResult<List<CountryMst>> GetAllCountry()
        {
            var countryList1 = databaseContext.countrymaster.ToList();
            return Ok(countryList1);
        }

        [HttpGet("GetStateById/{countryId}")]
        public ActionResult<List<CountryMst>> GetStateById(int countryId)
        {
            // return specific column
            var stateList = databaseContext.statemaster.Where(a=>a.countryMstId==countryId)
                .Select(a=>new { a.stateId,a.stateName });
            return Ok(stateList);
        }
    }
}
