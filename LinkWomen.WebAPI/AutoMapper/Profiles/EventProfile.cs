using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkWomen.WebAPI.AutoMapper.Profiles
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventDTO>()
                .ReverseMap(); 
        }
    }
}
