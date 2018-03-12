using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Chain chainCalc1 = new AddNumbers();
            Chain chainCalc2 = new SubtractNumbers();
            Chain chainCalc3 = new MultiplyNumbers();
            Chain chainCalc4 = new DivideNumbers();
            
            chainCalc1.SetNextChain(chainCalc2);
            chainCalc2.SetNextChain(chainCalc3);
            chainCalc3.SetNextChain(chainCalc4);

            Numbers request = new Numbers(4,2,"divide");
            chainCalc1.Calculate(request);
            Console.ReadLine();
        }
    }
}
