using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_OOP_Demo_C_.OOPInheritance
{
    internal class Child : Parent
    {
        public int z { get; set; }
        public Child(int x,int y,int z):base(x,y) 
        {
        this.z = z;
        }
    }
}
