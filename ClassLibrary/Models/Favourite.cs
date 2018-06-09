using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Favourite
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
