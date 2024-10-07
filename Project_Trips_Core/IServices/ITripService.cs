using Project_Trips_Core.ModelDto;
using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Core.IServices
{
    public interface ITripService
    {
        Task<bool> AddTrip(TripDto trip);
        Task<List<TripDto>> GetAllTrips();
        Task<bool> UpdateTrip(TripDto trip);
        Task<List<TripDto>> GetFutureTrips();
    }
}
