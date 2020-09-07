using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkWomen.WebAPI.AutoMapper.Profiles
{
    public class TechSkillProfile : Profile
    {
        public TechSkillProfile()
        {
            CreateMap<TechSkill, TechSkillDTO>(); 
        }
    }
}
