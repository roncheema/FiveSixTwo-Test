using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace hr.linq2
{
    class Program
    {
        public static List<Order> orders;

        static void Main(string[] args)
        {
            orders = new List<Order>()
            {
                new Order()
                {
                    id = 1,
                    customer = new Customer()
                    {
                        id = 100,
                        name = "Joes Bike Shop",
                        address = new Address()
                        {
                            id = 500,
                            street = "123 fake st.",
                            zip = "95264",
                            city = "LA",
                            state = "CA"
                        }
                    },
                    items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            id = 1000,
                            name = "button",
                            price = 25.25,
                            qty = 21
                        },
                        new OrderItem()
                        {
                            id = 1001,
                            name = "box",
                            price = 13.21,
                            qty = 7
                        }
                    }
                },
                new Order()
                {
                    id = 2,
                    customer = new Customer()
                    {
                        id = 101,
                        name = "Billy's Pawn Shop",
                        address = new Address()
                        {
                            id = 501,
                            street = "321 faker ave.",
                            zip = "92175",
                            city = "Irvine",
                            state = "CA"
                        }
                    },
                    items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            id = 1002,
                            name = "button",
                            price = 25.25,
                            qty = 2
                        },
                        new OrderItem()
                        {
                            id = 1003,
                            name = "calendar",
                            price = 10.75,
                            qty = 10
                        }
                    }
                }
            };

            //q1 customer addresses
            //var addresses = getAddressList();
            //addresses.ForEach(a => a.print());

            //var items = getAllOrderItems();
            //items.ForEach(i => i.print());

            setTotals();
            foreach (var order in orders)
            {
                order.print();
                order.customer.print();
                order.customer.address.print();
                foreach (var item in order.items)
                {
                    item.print();
                }
            }

            Console.ReadLine();
        }

        public static List<Address> getAddressList()
        {
            var query = orders.Where(o => o.items.Count > 1)
                .Select(o => o.customer.address);

            return query.ToList();

        }

        public static List<OrderItem> getAllOrderItems()
        {
            var query = orders.SelectMany(o => o.items);

            return query.ToList();
        }

        public static void setTotals()
        {
            foreach (var order in orders)
            {
                foreach (var item in order.items)
                {
                    order.tax += (item.qty*item.price)*.0775;
                    order.total += (order.tax + item.qty*item.price);

                }
            }
        }
    }
}
