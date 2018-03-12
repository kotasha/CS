using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));
            Console.WriteLine("Ingredients "+ basicPizza.getDescription());
            Console.WriteLine("Cost " + basicPizza.getCost());

            Console.ReadLine();
        }
    }
}
