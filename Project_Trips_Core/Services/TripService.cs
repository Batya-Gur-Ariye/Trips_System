using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project_Trips_Core.IServices;
using Project_Trips_Core.ModelDto;
using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Project_Trips_Core.Services
{
    public class TripService : ITripService
    {
        #region variables
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        public TripService(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Public methods
        public async Task<List<TripDto>> GetAllTrips()
        {
            List<TripDto> l = new List<TripDto>();
            try
            {
                var q =  _context.Trips.ToList();
                q.ForEach(a => l.Add(_mapper.Map<TripDto>(a)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return l;
        }

        public async Task<bool> AddTrip(TripDto t)
        {
            try
            {
                _context.Trips.Add(_mapper.Map<Trip>(t));
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;   
            }
            
        }

        public async Task<List<TripDto>> GetFutureTrips()
        {
            List<TripDto> tripList = new List<TripDto>();
            try
            {
                var trips =   _context.Trips
                    .Where(a => a.Status == eStatusTrip.confirmed)
                    .ToList();
                trips.ForEach(a => tripList.Add(_mapper.Map<TripDto>(a)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return tripList;
        }


        public async Task<bool> UpdateTrip(TripDto t)
        {
            _mapper.Map<TripDto>(t);
            var existTrip = _context.Trips.Where(x => x.Name.Equals(t.Name)).FirstOrDefault();
            if (existTrip == null)
                return false;
            try
            {
                existTrip.Name = t.Name;
                existTrip.Description = t.Description;
                existTrip.StartDate = t.StartDate;
                existTrip.EndDate = t.EndDate;
                existTrip.Status = t.Status;
                existTrip.NumOfParticipants = t.NumOfParticipants;
                existTrip.UserId = t.UserId;
                _context.SaveChanges();

                if (t.Status == eStatusTrip.performed)
                    SwitchOrderStatus(existTrip.TripId);

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        private void SwitchOrderStatus(int TripId)
        {
            _context.Orders.Where(x => x.TripId == TripId).ToList()
            .ForEach(o => o.Status = eStatusOrder.fulfilled);
            _context.SaveChanges();
        }
        #endregion
    }
}


