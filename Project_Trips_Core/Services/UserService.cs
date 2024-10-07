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
public class UserService: IUserService
{
    #region variables
    private readonly MyDbContext _context;
    private readonly IMapper _mapper;
        #endregion

        #region Ctor
        public UserService(MyDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
        #endregion

        #region Public methods
        public async Task<List<UserDto>> GetAllUser()
        {

            List<UserDto> u = new List<UserDto>();
            var q = _context.Users.ToList();
            q.ForEach(a => u.Add(_mapper.Map<UserDto>(a)));
            return u;
        }
        public async Task<bool> AddUser(UserDto ud)
        {
            User u = _mapper.Map<User>(ud);
            _context.Users.Add(u);
            _context.SaveChanges();

            return true;
        }
        public async Task<UserDto> Login(string userName, string password)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(x => x.UserName == userName && x.Password.Equals(password));
                if (user != null)
                {
                    return _mapper.Map<UserDto>(user);
                }
                else
                {
                    Console.WriteLine("the user doesnt exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return null!;
        }
        #endregion
    }
}

