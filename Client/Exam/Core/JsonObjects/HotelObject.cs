using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Core.JsonObjects
{
    public class HotelObject
    {
        public int id { get; set; }
        public string hotelName { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string image { get; set; }
        public int stars { get; set; }
        public int cost { get; set; }
        public string info { get; set; }
    }
}
