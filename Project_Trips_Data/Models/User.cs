using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Data.Models
{
    public class User
    {
        #region Properties
        [Key]
        [MinLength(9), MaxLength(9)]
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        [MaxLength(6)]
        public string? Password { get; set; }
        [MinLength(2)]
        public string? FirstName { get; set; }
        [MinLength(2)]
        public string? LastName { get; set; }
        [MinLength(10), MaxLength(10)]
        public string? PhoneNumber { get; set; }
        [EmailAddress]
        public string?  Email { get; set; }
        public bool IsAdmin { get; set; }
        #endregion
    }
}
