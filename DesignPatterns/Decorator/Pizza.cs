using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  

namespace Decorator
{
    public interface IPizza
    {
         string getDescription();
         double getCost();
    }
    public class PlainPizza : IPizza
    {
        public string getDescription()
        {
            return "Thin Dough";        
        }
        public double getCost()
        {
            return 4.00;
        }
    }

    public abstract class ToppingDecorator: IPizza
    {
        protected IPizza tempPizza;
        public ToppingDecorator(IPizza newPizza)
        {
            tempPizza = newPizza;
        }
        public virtual string getDescription()
        {
            return tempPizza.getDescription();
        }
        public virtual double getCost()
        {
            return tempPizza.getCost();
        }
    }
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza newPizza) : base(newPizza) 
        {
            Console.WriteLine("Adding Dough");
            Console.WriteLine("Adding Mozzarella");
        }
        public override string getDescription()
        {
            return tempPizza.getDescription() +", Mozzarella";
        }
        public override double getCost()
        {
            return tempPizza.getCost() + 1 ;
        }

    }
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza newPizza)
            : base(newPizza)
        {
            Console.WriteLine("Adding Sauce");
        }
        public override string getDescription()
        {
            return tempPizza.getDescription() + ", Tomato Sauce";
        }
        public override double getCost()
        {
            return tempPizza.getCost() + .25;
        }

    }
}
