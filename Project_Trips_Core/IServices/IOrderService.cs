using Project_Trips_Core.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Core.IServices
{
    public interface IOrderService
    {
        Task<bool> AddOrder(OrderDto order);
        Task<List<OrderDto>> GetAllOrders();
        Task<List<OrderWithUserDetails>> GetOrdersWithUserDataByTripIdAsync(int tripId);
        Task<List<GetOrderWithTripDetails>> GetOrdersByIdAsync(string userId);
    }
}
