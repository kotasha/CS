using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Hoagie cust1 = new ItalianHoagie();
            cust1.makeSandwich();

            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");

            Hoagie cust2 = new VeggieHoagie();
            cust2.makeSandwich();

            Console.ReadLine();
        }
    }
}
