using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Customer mapper
            Mapper.CreateMap<Customer, CustomerDto>()
                .ForSourceMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>();
            //movie mapper
            Mapper.CreateMap<Movie, MovieDto>()
                .ForSourceMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>();

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
        }
    }
}