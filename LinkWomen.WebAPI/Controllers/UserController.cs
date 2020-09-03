using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Domain.Models;
using LinkWomen.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace LinkWomen.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper, IUserService userService)
        {
            _userService = userService;
            _mapper = mapper; 
        }

        [HttpGet("{id}")]
        public ActionResult<UserDTO> Get(int id)
        {
           var user = _userService.GetById(id);

            if (user == null)
                return NotFound("Usuário não encontrado");

            return _mapper.Map<UserDTO>(user); 
        }

        /// <summary>
        /// Create a user
        /// </summary>
        /// <param name="userDTO"></param>
        [HttpPost]
        public void Post([FromBody] UserCreateDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            _userService.Add(user); 
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
