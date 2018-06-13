using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public bool Computers { get; set; }
        public bool Projector { get; set; }
        public bool LoudSpeakers { get; set; }
        public bool Microphone { get; set; }
        public bool Availability { get; set; }
    }
}
