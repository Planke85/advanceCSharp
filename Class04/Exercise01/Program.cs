using System;
using System.Collections.Generic;
using Models;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog(4, "Rex", "Brown"),
                new Dog(-1, "Lara", "Yellow"),
                new Dog(1, "", "Yellow"),
                new Dog(5, "Marlo", "Black"),
                new Dog()
            };

            foreach (Dog dog in dogs)
            {
                if (Dog.Validate(dog))
                {
                    DogShelter.Dogs.Add(dog);
                }
            }

            Console.WriteLine(DogShelter.GetAllDogsNames());
        }
    }
}
