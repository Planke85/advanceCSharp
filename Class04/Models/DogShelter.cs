using System;
using System.Collections.Generic;

namespace Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog>
            {
                new Dog(1, "Liza", "Gold"),
                new Dog(2, "Max", "Black"),
                new Dog(3, "Lina", "White")
            };
        }

        public static string GetAllDogsNames()
        {
            if (Dogs.Count == 0)
            {
                return $"There are no dogs available at the moment!";
            }

            string dogNames = "";
            int counter = 1;

            foreach (Dog dog in Dogs)
            {
                dogNames += $"{counter}. {dog.Name}\n";
                counter++;
            }

            return dogNames;
        }
    }
}
