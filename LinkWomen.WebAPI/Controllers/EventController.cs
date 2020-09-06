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
    public class EventController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEventService _eventService;
        private readonly IUserService _userService;

        public EventController(IMapper mapper, IUserService userService, IEventService eventService)
        {
            _mapper = mapper; 
            _userService = userService; 
            _eventService = eventService; 
        }

        [HttpGet]
        [Route("All")]
        [AllowAnonymous]
        public IEnumerable<EventDTO> GetAll()
        {
            var events = _eventService.GetAll().Select(x => _mapper.Map<EventDTO>(x)).ToList();
            return events; 
        }

        [HttpGet]
        [Route("{id:int}")]
        [AllowAnonymous]
        public ActionResult<EventDTO> Get(int id)
        {
            var entity = _eventService.GetById(id);

            if (entity == null)
                return NotFound(); 

            return _mapper.Map<EventDTO>(entity);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Post([FromBody] EventDTO dto)
        {
            var entity = _mapper.Map<Event>(dto);

            var user = _userService.GetByUserName(User.Identity.Name);

            if (user == null)
                return StatusCode(401, "usuário não autenticado");

            entity.UserId = user.Id; 
            _eventService.Add(entity);

            return NoContent(); 
        }
    }
}
