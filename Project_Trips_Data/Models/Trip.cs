using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Data.Models
{
    public class Trip
    {
        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TripId { get; set; }
        [MinLength(2)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public int NumOfParticipants { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public eStatusTrip Status { get; set; }
        
        public DateTime CreatingDate { get; set; } = DateTime.Now;
        [MaxLength(9)]
        public string UserId { get; set; } 
        #endregion
    }
    public enum eStatusTrip
    {
        confirmed = 0,
        cancled = 1,
        performed = 2
    }
}
