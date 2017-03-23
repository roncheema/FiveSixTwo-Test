using System;
using System.Collections.Generic;
using System.Linq;

namespace hr.linq
{
    class Program
    {
        private static List<Dog> dogs;

        static void Main(string[] args)
        {
            dogs = new List<Dog>()
            {
                new Dog() {id = 1, name = "Fido", age = 10, sortOrder = 2},
                new Dog() {id = 2, name = "Spot", age = 1, sortOrder = 0},
                new Dog() {id = 3, name = "Sam", age = 4, sortOrder = 0},
                new Dog() {id = 4, name = "Jim", age = 12, sortOrder = 5},
                new Dog() {id = 5, name = "Spotty", age = 2, sortOrder = 4},
                new Dog() {id = 6, name = "Alfred", age = 4, sortOrder = 1}
            };

            printDogNames();
            printDogsInOrder();
            printDogsOverAge3();

            Console.Read();
        }

        static void printDogNames()
        {
            var query = dogs.Select(d => d.name);

            foreach (var d in query)
            {
                Console.WriteLine("Name - " + d);
                Console.WriteLine("--------------------");

            }
        }

        static void printDogsInOrder()
        {
            var query = dogs.OrderBy(d => d.sortOrder)
                .Select(d => new Dog
                {
                    id = d.id,
                    name = d.name
                });
    
            foreach (var d in query)
            {
                Console.WriteLine("Dog - " + d.id);
                Console.WriteLine("Name - " + d.name);
                Console.WriteLine("--------------------");
            }

        }

        static void printDogsOverAge3()
        {
            var query = dogs.OrderByDescending(d => d.sortOrder)
                .Where(d => d.age > 3)
                .Select(d => new Dog
                {
                    id = d.id,
                    name = d.name
                });
            foreach (var d in query)
            {
                Console.WriteLine("Dog - " + d.id);
                Console.WriteLine("Name - " + d.name);
                Console.WriteLine("--------------------");
            }
        }
    }
}
