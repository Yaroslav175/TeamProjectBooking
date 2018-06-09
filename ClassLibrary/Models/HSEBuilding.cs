using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class HSEBuilding
    {
        public int Floors { get; set; }
        public string Address { get; set; }

        public List<Room> Rooms { get; set; }
    }
}
