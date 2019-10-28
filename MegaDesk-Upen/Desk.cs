﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Upen
{
    public enum Surface
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }


    public class Desk
    {
        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public Surface SurfaceMaterial { get; set; }

        public int NumberOfDrawers { get; set; }
    }
}
