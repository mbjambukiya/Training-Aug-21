﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_13_Assignment.Models
{
    class ToyType
    {
        public int typeId { get; set; }
        public string typeName { get; set; }
        public ToyPlant ToyPlantNavigation { get; set; }
        public bool isActive { get; set; }
    }
}
