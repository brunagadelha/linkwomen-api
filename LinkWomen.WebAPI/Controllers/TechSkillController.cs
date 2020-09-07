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
    public class TechSkillController : ControllerBase
    {
        private readonly ITechSkillService _techSkillService; 
        private readonly IMapper _mapper; 

        public TechSkillController(ITechSkillService techSkillService, IMapper mapper)
        {
            _mapper = mapper; 
            _techSkillService = techSkillService; 
        }

        [HttpGet]
        [Route("All")]
        [Authorize]
        public IEnumerable<TechSkillDTO> GetAll()
        {
            var skills = _techSkillService.GetAll();

            return _mapper.Map<IEnumerable<TechSkillDTO>>(skills); 
        }

    }
}
