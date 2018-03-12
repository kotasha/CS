using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public interface Chain
    {
        void SetNextChain(Chain nextChain);
        void Calculate(Numbers request);
    }

    public class Numbers 
    {
        int number1,number2;    string calculationWanted;
        public Numbers(int num1,int num2,string calcWanted)
        {
            number1 = num1;
            number2 = num2;
            calculationWanted = calcWanted;
        }
        public int GetNumber1() { return this.number1; }
        public int GetNumber2() { return this.number2; }
        public string GetCalculationWanted() { return this.calculationWanted; }
    }
    public class AddNumbers : Chain
    {
        Chain nextInChain;
        public void SetNextChain(Chain nextChain)
        {
            nextInChain = nextChain;
        }
        public void Calculate(Numbers request)
        {
            if (request.GetCalculationWanted() == "add")
            {
                Console.WriteLine(request.GetNumber1() + "+" + request.GetNumber2() + "=" + (request.GetNumber1() + request.GetNumber2()));
            }
            else
            {
                nextInChain.Calculate(request);
            }

        }
    }
    public class SubtractNumbers : Chain
    {
        Chain nextInChain;
        public void SetNextChain(Chain nextChain)
        {
            nextInChain = nextChain;
        }
        public void Calculate(Numbers request)
        {
            if (request.GetCalculationWanted() == "sub")
            {
                Console.WriteLine(request.GetNumber1() + "-" + request.GetNumber2() + "=" + (request.GetNumber1() - request.GetNumber2()));
            }
            else
            {
                nextInChain.Calculate(request);
            }

        }
    }
    public class MultiplyNumbers : Chain
    {
        Chain nextInChain;
        public void SetNextChain(Chain nextChain)
        {
            nextInChain = nextChain;
        }
        public void Calculate(Numbers request)
        {
            if (request.GetCalculationWanted() == "multiply")
            {
                Console.WriteLine(request.GetNumber1() + "*" + request.GetNumber2() + "=" + (request.GetNumber1() * request.GetNumber2()));
            }
            else
            {
                nextInChain.Calculate(request);
            }

        }
    }
    public class DivideNumbers : Chain
    {
        Chain nextInChain;
        public void SetNextChain(Chain nextChain)
        {
            nextInChain = nextChain;
        }
        public void Calculate(Numbers request)
        {
            if (request.GetCalculationWanted() == "divide")
            {
                Console.WriteLine(request.GetNumber1() + "/" + request.GetNumber2() + "=" + (request.GetNumber1() / request.GetNumber2()));
            }
            else
            {
                Console.WriteLine("Only works for Add,Div,Sub,Mult");
            }

        }
    }
}
