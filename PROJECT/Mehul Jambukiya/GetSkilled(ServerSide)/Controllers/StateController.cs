using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;
using GetSkilled.Helper;
using GetSkilled.Models;
using GetSkilled.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetSkilled.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = UserRoles.Admin)]
    public class StateController : ControllerBase
    {
        private readonly IState _state;
        private readonly IMapper _mapper;
        public StateController(IState state,IMapper mapper)
        {
            _state = state;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetStatesList()
        {
            try
            {
                var result = _state.GetAllData();
                var stateList = new List<StateDto>();

                foreach (var i in result)
                {
                    if (i.IsDeleted == false)
                    {
                        var state = _mapper.Map<StateDto>(i);
                        stateList.Add(state);
                    }
                }

                if (stateList.Any())
                {
                    return Ok(stateList);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{stateId}")]
        public IActionResult GetStateById(int stateId)
        {
            try
            {
                var result = _state.GetDataById(stateId);

                if (result != null && result.IsDeleted==false)
                {
                    var state = _mapper.Map<StateDto>(result);
                    return Ok(state);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult AddState(State state)
        {
            try
            {
                var result = _state.CreateData(state);
                if (result == true)
                {
                    _state.SaveData();
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut()]
        public IActionResult UpdateState(State state)
        {
            try
            {
                if (state.IsDeleted == false)
                {
                    var result = _state.UpdateData(state);
                    if (result == true)
                    {
                        _state.SaveData();
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("{stateId}")]
        public IActionResult DeleteState(int stateId)
        {
            try
            {
                var result = _state.DeleteData(stateId);
                if (result == true)
                {
                    _state.SaveData();
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
