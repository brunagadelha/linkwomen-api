using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinkWomen.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public SessionController(IMapper mapper, IUserService userService)
        {
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public ActionResult<SessionDTO> Post([FromBody] LoginDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); 

            var user = _userService.VerifyUser(dto.UserName, dto.Password);

            if (user == null)
                return StatusCode(400, "Usuário ou senha inválidos");

            var token = TokenService.GenerateToken(user);

            return new SessionDTO
            {
                User = _mapper.Map<UserDTO>(user),
                Token = token
            }; 
        }

    }
}
