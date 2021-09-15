using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListApi.Dtos;
using ToDoListApi.Models;

namespace ToDoListApi.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ActivityDto, Activity>();
            CreateMap<Activity, ActivityDto>();
        }
    }
}
