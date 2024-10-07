using AutoMapper;
using Project_Trips_Core.ModelDto;
using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Core.Profiles
{
    public class TripProfile : Profile
    {
        public TripProfile()
        {
            CreateMap<TripDto, Trip>();
            CreateMap<Trip, TripDto>();
        }
    }
}
