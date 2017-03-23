using System;
using System.Collections.Generic;

namespace hr.oop
{
    class Program
    {
        private static void printDashes()
        {
            Console.WriteLine("--------------------");
        }

        private static List<Dog> dogs;
        private static List<Cat> cats;
        static void Main(string[] args)
        {
                dogs = new List<Dog>()
            {
                new Dog() {id = 1, name = "Fido", age = 10, sortOrder = 2, breed = "Akita"},
                new Dog() {id = 2, name = "Spot", age = 1, sortOrder = 0, breed = "German Shepherd"},
                new Dog() {id = 3, name = "Sam", age = 4, sortOrder = 0, breed = "Labrador Retriever"},
                new Dog() {id = 4, name = "Jim", age = 12, sortOrder = 5, breed = "Akita"},
                new Dog() {id = 5, name = "Spotty", age = 2, sortOrder = 4, breed = "German Shepherd"},
                new Dog() {id = 6, name = "Alfred", age = 4, sortOrder = 1, breed = "Labrador Retriever"}
            };


                cats = new List<Cat>()
            {
                new Cat() {id = 1, name = "Fido", age = 10, sortOrder = 2, lives = 4},
                new Cat() {id = 2, name = "Spot", age = 1, sortOrder = 0, lives = 9},
                new Cat() {id = 3, name = "Sam", age = 4, sortOrder = 0, lives = 1},
                new Cat() {id = 4, name = "Jim", age = 12, sortOrder = 5, lives = 2},
                new Cat() {id = 5, name = "Spotty", age = 2, sortOrder = 4, lives = 5},
                new Cat() {id = 6, name = "Alfred", age = 4, sortOrder = 1, lives = 6}
            };

            foreach (var dog in dogs)
            {
                dog.print();
            }

            printDashes();

            foreach (var cat in cats)
            {
                cat.print();
            }

            Console.ReadLine();
        }
    }
}
