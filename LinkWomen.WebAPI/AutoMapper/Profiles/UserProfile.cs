using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkWomen.WebAPI.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateDTO, User>()
                .ForMember(fm => fm.PasswordHash, mo => mo.MapFrom(x => x.Password));

            CreateMap<User, UserDTO>();
        }
    }
}
