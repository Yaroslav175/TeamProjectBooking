﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
   public class Floor
    {
        public List<Room> Rooms { get; set; }
        public int Number { get; set; }
    }
}
