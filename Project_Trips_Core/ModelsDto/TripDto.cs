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
    public class TripDto
    {
        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TripId { get; set; }
        [MinLength(2)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumOfParticipants { get; set; }
        public eStatusTrip Status { get; set; }
        [MaxLength(9)]
        public string UserId { get; set; }

        #endregion

    }
}
