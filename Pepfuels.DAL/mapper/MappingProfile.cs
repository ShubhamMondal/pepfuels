using AutoMapper;
using Pepfuels.DAL.Entity.Models;
using Pepfuels.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pepfuels.DAL.mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Country, Country_VM>();
            CreateMap<State, State_VM>();
        }
    }
}
