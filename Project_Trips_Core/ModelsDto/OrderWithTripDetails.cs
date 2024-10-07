
using Project_Trips_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Core.ModelDto
{
    public class GetOrderWithTripDetails
    {
        #region Properties
        public string TripName { get; set; }
        public string Description { get; set;}
        public DateTime CreateDate  { get; set;}
        public eStatusOrder StatusOrder { get; set;}
        #endregion

        #region Ctor
        public GetOrderWithTripDetails()
        {
            
        }

        public GetOrderWithTripDetails(string tripName, string description, DateTime createDate, eStatusOrder statusOrder)
        {
            TripName = tripName;
            Description = description;
            CreateDate = createDate;
            StatusOrder = statusOrder;
        }



        #endregion
    }


}
