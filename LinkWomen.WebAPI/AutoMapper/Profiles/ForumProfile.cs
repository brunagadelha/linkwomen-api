using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkWomen.WebAPI.AutoMapper.Profiles
{
    public class ForumProfile : Profile
    {
        public ForumProfile()
        {
            CreateMap<ForumIssue, ForumIssueDTO>()
                .ForMember(fm => fm.User, mo => mo.MapFrom(x => x.User.Name))
                .ForMember(fm => fm.Category, mo => mo.MapFrom(x => x.Category != null ? x.Category.Name : null))
                .ForMember(fm => fm.CreatedAt, mo => mo.MapFrom(x => x.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss")));

            CreateMap<ForumIssueCreateDTO, ForumIssue>(); 

            CreateMap<ForumCommentDTO, ForumComment>();

            CreateMap<ForumComment, ForumCommentDTO>()
                .ForMember(fm => fm.Content, mo => mo.MapFrom(x => x.Comment))
                .ForMember(fm => fm.User, mo => mo.MapFrom(x => x.User.Name))
                .ForMember(fm => fm.CreatedAt, mo => mo.MapFrom(x => x.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss")));
        }
    }
}
