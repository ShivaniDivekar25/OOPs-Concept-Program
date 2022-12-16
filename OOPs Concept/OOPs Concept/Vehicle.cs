using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concept.OOPs_Concept
{
    internal class Vehicle
    {
        public string brand;
        public float price;

        public void VehicleDetails()
        {
            Console.WriteLine("Brand:{0} price:{1}",brand,price);
        }
    }
}
