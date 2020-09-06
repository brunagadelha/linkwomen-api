using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Domain.Models;
using LinkWomen.Services.Services;
using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// Get user details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [Authorize]
        public ActionResult<UserDTO> Get(int id)
        {
           var user = _userService.GetById(id);

            if (user == null)
                return NotFound("Usuário não encontrado");

            return _mapper.Map<UserDTO>(user); 
        }

        /// <summary>
        /// Create user
        /// </summary>
        /// <param name="userDTO"></param>
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Post([FromBody] UserCreateDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            _userService.Add(user);

            return NoContent();
        }

        /// <summary>
        /// Update bio description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bio"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/UpdateBio")]
        [AllowAnonymous]
        public ActionResult UpdateBio(int id, [FromBody] string bio)
        {
            var user = _userService.GetById(id);

            if (user == null)
                return NotFound("Usuário não encontrado");

            user.Bio = bio; 
            _userService.Update(user);

            return NoContent();
        }

        /// <summary>
        /// Update basic data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [AllowAnonymous]
        public ActionResult UpdateBasicData(int id, [FromBody] UserBasicDataDTO dto)
        {
            var user = _userService.GetById(id);

            if (user == null)
                return NotFound("Usuário não encontrado");

            user.Occupation = dto.Occupation;
            user.CPF = dto.CPF;
            user.Name = dto.Email;
            user.UserName = dto.UserName;
            user.GitHub = dto.GitHub;
            user.Email = dto.Email;

            _userService.Update(user);

            return NoContent();
        }

        /// <summary>
        /// Highlighted users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Highlighted")]
        public IEnumerable<UserHighlightedDTO> GetHighlightedUsers()
        {
            var users = _userService.GetHighlightedUsers();

            return _mapper.Map<IEnumerable<UserHighlightedDTO>>(users); 
        }
    }
}
