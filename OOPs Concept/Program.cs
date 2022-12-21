using OOPs_Concept.OOPs_Concept;
using System.Net.NetworkInformation;
using static OOPs_Concept.Abstraction;

namespace OOPs_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from bellow option");
            Console.WriteLine("1:Inheritance\n2:Abstraction\n3:Polmorphisum\n4:MethodOverriding");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Car car = new Car();
                    car.brand = "Audi";
                    car.price = 100000000;
                    car.VehicleDetails();
                    car.Start();

                    Bike bike = new Bike();
                    bike.brand = "Unicorn";
                    bike.price = 1000000;
                    bike.VehicleDetails();
                    bike.Start();
                    break;
                case 2:
                    Pig pig = new Pig(); // Create a Pig object
                    pig.animalSound();  // Call the abstract method
                    pig.sleep();  // Call the regular method
                    break;
                case 3:
                    Apple obj = new Apple();
                    obj.PrintName();
                    break;
                case 4:
                    Animal animal = new Animal();  // Create a Animal object
                    animal.Run();
                    Dog dog = new Dog();
                    dog.Run();
                    break;
                default:
                    Console.WriteLine("Please choose given option");
                    break;
            }
            Console.ReadLine();
        }
    }
}