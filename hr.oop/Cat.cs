using System;

namespace hr.oop
{
    public class Cat : IAnimal
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int lives { get; set; }
        public int sortOrder { get; set; }

        public void print()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(lives);
        }
    }
}
