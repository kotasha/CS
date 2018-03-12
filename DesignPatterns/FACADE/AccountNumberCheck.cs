using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACADE
{
    public class AccountNumberCheck
    {
        private int accountNumber = 12345678;

        public int getAccountNumber()
        {
            return accountNumber;
        }
        public bool accountActive(int acctNumToCheck)
        {
            if (acctNumToCheck == getAccountNumber())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;

        AccountNumberCheck acctChecker;
        SecurityCodeCheck codeChecker;
        FundsCheck fundChecker;
        WelcomeToBank bankWelcome;

        public BankAccountFacade(int newaccountNumber, int newsecurityCode)
        {
            accountNumber = newaccountNumber;
            securityCode = newsecurityCode;

            acctChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
            bankWelcome = new WelcomeToBank();
        }

        public int getAccountNumber()
        {
            return accountNumber;
        }
        public int getSecurityCode()
        {
            return securityCode;
        }

        public void withdrawCash(double cashToGet)
        {
            if (acctChecker.accountActive(getAccountNumber()) && codeChecker.isCodeCorrect(getSecurityCode()) && fundChecker.haveEnoughMoney(cashToGet))
            {
                System.Console.WriteLine("Transaction Complete");
            }
            else
            {
                System.Console.WriteLine("Transaction Failed");
            }

        }

        public void depositCash(double cashToDeposit)
        {
            if (acctChecker.accountActive(getAccountNumber()) && codeChecker.isCodeCorrect(getSecurityCode()))
            {
                fundChecker.makeDeposit(cashToDeposit);
                System.Console.WriteLine("Transaction Complete");
            }

        }
    }
    public class WelcomeToBank
    {
           public WelcomeToBank()
           {
               Console.WriteLine("Welcome to KBC bank ");
           }

    }
    public class FundsCheck
    {
        private double cashInAccount = 1000;
        public double getCashInAccount()
        {
            return cashInAccount;
        }
        public void decreaseCashInAccount(double cashWithDrawn)
        {
            cashInAccount -= cashWithDrawn;
        }
        public void increaseCashInAccount(double cashDeposited)
        {
            cashInAccount += cashDeposited;
        }
        public bool haveEnoughMoney(double cashToWithdrawal)
        {
            if (cashToWithdrawal > getCashInAccount())
            {
                System.Console.WriteLine("InSufficient Funds");
                System.Console.WriteLine("Current Balance is " + "" + getCashInAccount());
                return false;
            }
            else
            {
                decreaseCashInAccount(cashToWithdrawal);
                System.Console.WriteLine("WithDrawal Complete: Current Balance is"+ ""+getCashInAccount());
                return true;
            }
        }

        public void makeDeposit(double cashToDesposit)
        {
            increaseCashInAccount(cashToDesposit);
            Console.WriteLine("Deposit complete: Current Balance is "+ +getCashInAccount());
        }

    }
    public class SecurityCodeCheck
    {
        private int securityCode = 1234;

        public int getsecurityCode()
        {
            return securityCode;
        }
        public bool isCodeCorrect(int secCodeToCheck)
        {
            if (secCodeToCheck == getsecurityCode())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 
    }
    
}
