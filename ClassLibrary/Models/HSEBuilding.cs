using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class HSEBuilding
    {   
        public string Address { get; set; }
        public List<Floor> Floors { get; set; }
    }
}
