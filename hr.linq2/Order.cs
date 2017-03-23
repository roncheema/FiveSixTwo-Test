using System;
using System.Collections.Generic;

namespace hr.linq2
{
    internal class Order : MyClass
    {
        public Customer customer { get; set; }
        public List<OrderItem> items { get; set; }
        public double tax { get; set; }
        public double total { get; set; }

        public new void print()
        {
            base.print();
            Console.WriteLine("tax - " + this.tax);
            Console.WriteLine("total - " + this.total);
        }
    }
}
