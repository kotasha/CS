using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACADE
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountFacade bankAccount = new BankAccountFacade(12345678,1234);
            bankAccount.withdrawCash(50);
            bankAccount.withdrawCash(900);
            bankAccount.depositCash(200);
            Console.Read();
        }
    }
}
