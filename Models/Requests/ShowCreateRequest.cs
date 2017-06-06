using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleC29CrudApp.Models.Requests
{
    public class ShowCreateRequest
    {
        public int VenueID { get; set; }

        public string ShowName { get; set; }

        public decimal Cost { get; set; }

        public DateTime Date { get; set; }

        public string FlyerUrl { get; set; }

        public DateTime StartTime { get; set; }
        
    }
}