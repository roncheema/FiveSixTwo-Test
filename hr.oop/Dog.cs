using System;

namespace hr.oop
{
    public class Dog : IAnimal
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int sortOrder { get; set; }
        public string breed { get; set; }

        public void print()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(breed);
        }
    }
}
