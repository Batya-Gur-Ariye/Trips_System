using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Project_Trips_Data.Models
{
    public class Order
    {
        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [ForeignKey("Trip")]
        public int TripId { get; set; }
        [JsonIgnore]
        public virtual Trip Trip { get; set; } = null!;
        [MinLength(9), MaxLength(9)]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; } = null!;
        public DateTime Createdate { get; set; }
        public eStatusOrder Status { get; set; }
        #endregion
    }

    public enum eStatusOrder
    {
        waitingToBeFulfilled = 0,
        fulfilled = 1,
        cancled = 2,

    }
}
