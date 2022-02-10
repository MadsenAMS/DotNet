using D_FourthProject.Models;
using System;

namespace D_FourthProject{

    class Program{

        static void Main(string[] args){

            Console.WriteLine("\nFirst Operation (CurrentAccount)");
            CurrentAccount currentAccount = new CurrentAccount(321546);
            currentAccount.Deposit(500);
            currentAccount.Withdraw(200);
            currentAccount.ShowBalance();

            Console.WriteLine("\nSecond Operation (SavingsAccount)");
            SavingsAccount savingsAccount = new SavingsAccount(321546);
            savingsAccount.Deposit(500);
            savingsAccount.Withdraw(200);
            savingsAccount.ShowBalance();

        }

    }

}