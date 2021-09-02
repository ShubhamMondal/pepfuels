using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pepfuels.Microservices.Interface;
using Pepfuels.DAL.Models;
using System.Net;
using Pepfuels.DAL.Entity.Models;
using AutoMapper;

namespace Pepfuels.WebAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public class CountryController : Controller
    {
        #region Readonly
        private readonly ICountry _ICountry;
        private readonly IMapper _mapper;
        #endregion
        public CountryController(ICountry ICountry, IMapper mapper)
        {
            _ICountry = ICountry;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<Country_VM>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> getCountries()
        {
            try
            {
                List<Country_VM> lstCountry = new List<Country_VM>();
                lstCountry = _mapper.Map<List<Country_VM>>(await _ICountry.GetAll());
                return Ok(lstCountry);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
