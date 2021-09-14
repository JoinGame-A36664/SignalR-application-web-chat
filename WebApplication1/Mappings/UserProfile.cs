using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Entities;
using WebApplication1.Models;

namespace WebApplication1.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ManageUser, UserViewModel>()
                .ForMember(dst => dst.Username, opt => opt.MapFrom(x => x.UserName));
            CreateMap<UserViewModel, ManageUser>();
        }
    }
}
