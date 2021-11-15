using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_13_Assignment.Models
{
    class Toy
    {
        public int toyId { get; set; }
        public string toyName { get; set; }
        public double toyPrice { get; set; }
        public int toyPlantId { get; set; }
        public ToyPlant ToyPlantNavigation { get; set; }
        public ICollection<Item> ItemNavigation { get; set; }
        public bool isActive { get; set; }

    }
}
