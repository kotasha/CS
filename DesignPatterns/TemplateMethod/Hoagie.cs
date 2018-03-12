using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public class Hoagies
    {
        public virtual void makeSandwich()
        { 
        }
    }
    public abstract class Hoagie : Hoagies
    {
        public sealed override void makeSandwich()
        {
            cutBun();
            
            if (customerWantsMeat())
                addMeat();
            if (customerWantsCheese())
                addCheese();
            if (customerWantsCondiments())
                addCondiments();
            if (customerWantsVegetables())
                addVegetables();
            
            wrapHoagie();
        }
        public abstract void addMeat();
        public abstract void addCheese();
        public abstract void addCondiments();
        public abstract void addVegetables();
        public void cutBun()
        {
            Console.WriteLine("Cut the Hoagie");
            Console.WriteLine("---------------------");
        }
        public virtual bool customerWantsMeat()
        {
            return true;
        }
        public virtual bool customerWantsCheese()
        {
            return true;
        }
        public bool customerWantsCondiments()
        {
            return true;
        }
        public bool customerWantsVegetables()
        {
            return true;
        }
        public void wrapHoagie()
        {
            Console.WriteLine("Wrap the Hoagie");
        }
        
    }
    public class ItalianHoagie: Hoagie
    {
        string[] meatUsed = {"Salami" ,"Pepperoni", "Capicola Ham"};
        string[] cheeseUsed = {"Provolone" };
        string[] veggiesUsed = { "Lettuce","Tomatoes","Onions","SweetPeppers" };
        string[] condimentsUsed = { "Oil","Vinegar" };
    
        public override void addMeat()
        {
            Console.WriteLine("ADDING Meat");
            
            foreach (string meat in meatUsed)
                Console.Write(meat+" ");
            Console.WriteLine();
            Console.WriteLine("---------------------");
        }
        public override void addCheese()
        {
            Console.WriteLine("ADDING Cheese");
                foreach(string cheese in cheeseUsed)
                    Console.Write(cheese+ " ");
                Console.WriteLine();    
            Console.WriteLine("---------------------");
        }
        public override void addCondiments()
        {
            Console.WriteLine("ADDING Condiments ");
            foreach(string condiment in condimentsUsed)
                Console.Write(condiment + " ");
            Console.WriteLine();
            Console.WriteLine("---------------------");
        }
        public override void addVegetables()
        {
            Console.WriteLine("ADDING Vegetables");
            foreach(string veggie in veggiesUsed)
                Console.Write(veggie +" ");
            Console.WriteLine();
            Console.WriteLine("---------------------");
            

        }
    }
    public class VeggieHoagie : Hoagie
    {
        string[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "SweetPeppers" };
        string[] condimentsUsed = { "Oil", "Vinegar" };

        public override bool customerWantsMeat()
        {
            return false;
        }
        public override bool customerWantsCheese()
        {
            return false;
        }
        
        public override void addMeat()
        {
        }
        public override void addCheese()
        {
        }
        public override void addCondiments()
        {
            Console.WriteLine("ADDING Condiments ");
            foreach (string condiment in condimentsUsed)
                Console.Write(condiment + " ");
            Console.WriteLine();
            Console.WriteLine("---------------------");
        }
        public override void addVegetables()
        {
            Console.WriteLine("ADDING Vegetables");
            foreach (string veggie in veggiesUsed)
                Console.Write(veggie + " ");
            Console.WriteLine();
            Console.WriteLine("---------------------");
        }
    }
}
