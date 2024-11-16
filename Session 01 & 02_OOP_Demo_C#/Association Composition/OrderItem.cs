using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_OOP_Demo_C_.Association_Composition
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public Product pro { get; set; }

        public decimal price { get; set; }
        public int quantity { get; set; }

        public OrderItem(Product pro)
        {
            this.pro = pro;
        }



    }
}
