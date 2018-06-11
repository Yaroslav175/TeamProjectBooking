using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{   public class GeneralData
    {
        public List<HSEBuilding> Buildings { get; set; }
    }

    internal class Repository: IRepository       
    {
        private GeneralData _general;
        public List<HSEBuilding> Buildings => _general.Buildings;
    }
}
