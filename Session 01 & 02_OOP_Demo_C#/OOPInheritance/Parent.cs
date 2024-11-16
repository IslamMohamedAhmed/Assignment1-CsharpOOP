﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_OOP_Demo_C_.OOPInheritance
{
    internal class Parent
    {
        public int x { get; set; }
        public int y { get; set; }
        public Parent(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public override string ToString()
        {
            return $"x = {x} and y = {y}";
        }

    }
}
