using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concept
{
    public class Fruit
    {
        public void PrintName()
        {
            Console.WriteLine("Fruit");
        }
    }
    public class Apple : Fruit
    {
        public void PrintName()
        {
            Console.WriteLine("Apple fruit");
        }
    }   
}
