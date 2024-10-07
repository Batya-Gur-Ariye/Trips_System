using Microsoft.AspNetCore.Mvc;
using Project_Trips_Core.IServices;
using Project_Trips_Core.ModelDto;

namespace Project_Trips_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        #region Variables

        private readonly IOrderService _OrdersService;
        #endregion

        #region Ctor
        public OrdersController(IOrderService OrdersService)
        {
            _OrdersService = OrdersService;
        }
        #endregion

        [HttpGet]
        [Route(nameof(GetAll))]
        public async Task<List<OrderDto>> GetAll()
        {
            return await _OrdersService.GetAllOrders();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route(nameof(AddOrder))]

        public async Task<IActionResult> AddOrder(OrderDto t)
        {
            bool isOK = await _OrdersService.AddOrder(t);
            return Ok(isOK);
        }

        [HttpGet("getOrdersWithUserDataByTripId")]
        public async Task<IActionResult> GetOrdersWithUserDataByTripId(int tripId)
        {
            var orders = await _OrdersService.GetOrdersWithUserDataByTripIdAsync(tripId);

            return Ok(orders);
        }
        [HttpGet("getOrdersByUserId")]
        public async Task<IActionResult> GetOrdersByUserIdAsync(string userId)
        {
            var orders = await _OrdersService.GetOrdersByIdAsync(userId);

            return Ok(orders);
        }
    }
}
