using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using UsersApi.Models;

namespace UsersApi.Helpers
{
    public class AutoMapperUser: Profile
    {
        public AutoMapperUser()
        {
            CreateMap<UserModel, UserDto>();
            CreateMap<UserDto, UserModel>();
        }
    }
}
