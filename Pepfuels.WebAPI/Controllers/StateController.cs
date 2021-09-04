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
    public class StateController : Controller
    {
        #region Readonly
        private readonly IState _IState;
        private readonly IMapper _mapper;
        #endregion
        public StateController(IState IState, IMapper mapper)
        {
            _IState = IState;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<State_VM>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> getStates()
        {
            try
            {
                List<State_VM> lstState = new List<State_VM>();
                lstState = _mapper.Map<List<State_VM>>(await _IState.GetList());
                return Ok(lstState);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(State_VM), (int)HttpStatusCode.OK)]
        [Route("{id}")]
        public async Task<IActionResult> getStateById(int id)
        {
            try
            {
                State_VM stateDetails = new State_VM();
                stateDetails = _mapper.Map<State_VM>(await _IState.GetById(id));
                return Ok(stateDetails);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
