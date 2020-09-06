using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinkWomen.WebAPI.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserConnectionController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserConnectionService _userConnectionService;
        private readonly IMapper _mapper;

        public UserConnectionController(IMapper mapper, IUserService userService, IUserConnectionService userConnectionService)
        {
            _userService = userService;
            _userConnectionService = userConnectionService;
            _mapper = mapper;
        }
        /// <summary>
        /// Get connections
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}/Connections")]
        [AllowAnonymous]
        public IEnumerable<UserDTO> GetConnections(int id)
        {
            var connections = _userConnectionService.GetConnections(id);

            return _mapper.Map<IEnumerable<UserDTO>>(connections);
        }

        /// <summary>
        /// Connect
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/Connect")]
        [AllowAnonymous]
        public ActionResult Connect(int id)
        {
            var userAutheticated = _userService.GetByUserName(User.Identity.Name);
            if (userAutheticated == null)
                return Unauthorized("Usuário não autenticado");

            var userToConnect = _userService.GetById(id);
            if (userAutheticated == null)
                return NotFound("Usuário não encontrado");

            _userConnectionService.Connect(userAutheticated.Id, userToConnect.Id);

            return NoContent();
        }

        /// <summary>
        /// Disconnect
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/Disconnect")]
        [AllowAnonymous]
        public ActionResult Disconnect(int id)
        {
            var userAutheticated = _userService.GetByUserName(User.Identity.Name);
            if (userAutheticated == null)
                return Unauthorized("Usuário não autenticado");

            var userToConnect = _userService.GetById(id);
            if (userAutheticated == null)
                return NotFound("Usuário não encontrado");

            _userConnectionService.Disconnect(userAutheticated.Id, userToConnect.Id);

            return NoContent();
        }
    }
}
