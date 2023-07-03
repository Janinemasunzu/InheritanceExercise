using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird() 
            { 
                name = "myBird",
                age = 5,
                legs = 2,
                HasBackbone = true,
                HasFeathers = true,
                wings = 3,
                LayEggs = true,
                WingColor = "black"

            };




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myreptile = new Reptile()
            {
                name = "myreptile",
                age = 7,
                legs = 6,
                HasBackbone = true,
                HasScalySkin = true,
                IsColdBlooded = true,
                HasLungs = true,
                Habitat = "Swamp"

            };


            var myanimal = new Animal[] { myBird, myreptile};
            foreach (var animal in myanimal) 
            { 
                Console.WriteLine($"age:{animal.age}");
                Console.WriteLine($"legs:{animal.legs}");
                Console.WriteLine($"name:{animal.name}");
                Console.WriteLine($"backbone:{animal.HasBackbone}");
                Console.WriteLine($"");
            }
        }
    }
}
