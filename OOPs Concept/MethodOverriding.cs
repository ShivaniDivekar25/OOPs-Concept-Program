using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concept
{
    class Animal
    {
        public virtual void Run()
        {
            Console.WriteLine("Running");
        }

    }
    class Dog : Animal
    {
        public  override void Run()
        {
            Console.WriteLine("Dog runnig so fast");
        }
    }
}
