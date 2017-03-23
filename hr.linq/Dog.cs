using System;

namespace hr.linq
{
    public class Dog
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int sortOrder { get; set; }

        public void print()
        {
            Console.WriteLine("Dog - " + this.id);
            Console.WriteLine("Name - " + this.name);
            Console.WriteLine("--------------------");
        }
    }
}
