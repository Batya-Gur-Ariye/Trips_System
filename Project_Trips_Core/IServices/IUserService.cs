using Project_Trips_Core.ModelDto;
using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Core.IServices
{
    public interface IUserService
    {
        Task<bool> AddUser(UserDto user);
        Task<List<UserDto>> GetAllUser();
        Task<UserDto> Login(string userName, string password);
    }
}
