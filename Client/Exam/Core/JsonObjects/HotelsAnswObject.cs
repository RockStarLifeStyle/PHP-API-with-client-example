using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Core.JsonObjects
{
    public class HotelsAnswObject
    {
        public bool successful { get; set; }
        public HotelObject[] hotels { get; set; }
    }
}
