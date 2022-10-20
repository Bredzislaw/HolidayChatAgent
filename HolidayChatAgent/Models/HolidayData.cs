using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChatAgent.Models
{
    public class HolidayData
    {
        public string HolidayReference { get; set; }
        public string HotelName { get; set; }
        public string City { get; set; }
        public string Continent { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
        public int StarRating { get; set; }
        public string TempRating { get; set; }
        public string Location { get; set; }
        public decimal PricePerNight { get; set; }    
    }
}
