
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project_Trips_Core.IServices;
using Project_Trips_Core.ModelDto;
using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Core.Services
{

    public class OrderService : IOrderService
    {
        #region variables
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        public OrderService(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Public methods
        public async Task<List<OrderDto>> GetAllOrders()
        {
            List<OrderDto> O = new List<OrderDto>();
            var q = _context.Orders.ToList();
            q.ForEach(a => O.Add(_mapper.Map<OrderDto>(a)));
            return O;
        }
        public async Task<List<OrderDto>> GetOrderByTripId(string name)
        {
            List<OrderDto> orderList = new List<OrderDto>();
            try
            {
                var trip =  _context.Trips.FirstOrDefault(t => t.Name.Equals(name));
                if (trip != null)
                {
                    var orders =  _context.Orders.Where(o => o.TripId == trip.TripId).ToList();
                    orders.ForEach(a => orderList.Add(_mapper.Map<OrderDto>(a)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return orderList;
        }

        public async Task<List<OrderWithUserDetails>> GetOrdersWithUserDataByTripIdAsync(int tripId)
        {
            try
            {
                var ordersWithUserDataList =   _context.Orders
                    .Where(t => t.TripId == tripId)
                    .Select(o => new OrderWithUserDetails
                    {                  
                        Createdate = o.Createdate,
                        Status = o.Status,               
                        FirstName = o.User.FirstName,
                        LastName = o.User.LastName,
                        Phone = o.User.PhoneNumber,
                    })
                    .ToList();

                return ordersWithUserDataList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<OrderWithUserDetails>();
            }
        }

        public async Task<bool> AddOrder(OrderDto order)
        {

            try
            {
                var trip =   _context.Trips.FirstOrDefault (t => t.TripId == order.TripId);
                if (trip != null)
                {
                    var countOrders =   _context.Orders.Count (o => o.TripId == trip.TripId);
                    if (countOrders < trip.NumOfParticipants)
                    {
                        Order o = _mapper.Map<Order>(order);
                        _context.Orders.Add(o);
                          _context.SaveChanges ();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("There isn't place for you in the current trip.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public async Task<List<GetOrderWithTripDetails>> GetOrdersByIdAsync(string userId)
        {
            try
            {
                var orders =   _context.Orders
                    .Where(u => u.UserId == userId)
                    .Select(o => new GetOrderWithTripDetails
                    {                     
                        TripName = o.Trip.Name,
                        Description = o.Trip.Description,
                        CreateDate = o.Createdate,
                        StatusOrder = ((eStatusOrder)o.Status)
                    }).ToList ();

                return orders;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<GetOrderWithTripDetails>();
            }
        }


        #endregion
    }
}
