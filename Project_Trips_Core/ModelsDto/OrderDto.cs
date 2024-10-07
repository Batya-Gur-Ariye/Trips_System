using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Core.ModelDto
{
    public class OrderDto
    {
        #region Properties     
        public int TripId { get; set; }
        [MinLength(9), MaxLength(9)]
        public string UserId { get; set; }
        public DateTime Createdate { get; set; }
        public eStatusOrder Status { get; set; }
        #endregion


    
    }
}
