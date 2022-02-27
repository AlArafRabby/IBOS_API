using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.User;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _Context;
        public UserController(IUser context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetUserAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetUserAll()
        {
            try
            {
                var dt = await _Context.GetUserAll();
                if (dt == null)
                {
                    return NotFound();
                }

                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetUserId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetUserById(long Id)
        {
            try
            {
                var dt = await _Context.GetUserById(Id);
                if (dt == null)
                {
                    return NotFound();
                }

                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetUserByClientId")]
        [SwaggerOperation(Description = "Example { UserByClientId: 0 }")]
        public async Task<IActionResult> GetUserByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetUserByClientId(CId);
                if (dt == null)
                {
                    return NotFound();
                }

                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("CreateUser")]
        [SwaggerOperation(Description = "Example { id: 0,  UserName: string,LoginId: string,  Password: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateUser(CreateUserDTO postUser)
        {
            try
            {
                var dt = await _Context.CreateUser(postUser);
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("EditUser")]
        [SwaggerOperation(Description = "Example { id: 0, UserName: string,LoginId: string,  Password: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditUser([FromBody] EditUserDTO User)
        {
            try
            {
                var dt = await _Context.EditUser(User);
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("CancelUser")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelUser([FromBody] CancelUserDTO User)
        {
            try
            {
                var dt = await _Context.CancelUser(User);
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}