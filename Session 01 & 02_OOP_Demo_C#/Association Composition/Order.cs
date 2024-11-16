using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_OOP_Demo_C_.Association_Composition
{
    internal class Order
    {
        public int BuyerId { get; set; }
        public string BuyerName { get; set; }

        public OrderItem[] OI { get; set; }


        public Order(int BuyerId, string BuyerName, OrderItem[] oi)
        {
            this.BuyerId = BuyerId;
            this.BuyerName = BuyerName;
            this.OI = oi;
        }



    }
}
