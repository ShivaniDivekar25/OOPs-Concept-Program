using OOPs_Concept.OOPs_Concept;

namespace OOPs_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from bellow option");
            Console.WriteLine("1:Inheritance");
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
                default:
                    Console.WriteLine("Please choose given option");
                    break;
            }
            Console.ReadLine();
        }
    }
}