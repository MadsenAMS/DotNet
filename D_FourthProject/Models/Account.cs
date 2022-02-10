using System;

namespace D_FourthProject.Models
{
    public abstract class Account
    {
        protected double balance = 0;
        protected int accountNumber;

        public Account(int accountNumber){
            this.accountNumber = accountNumber;
        }

        public void ShowBalance(){
            Console.WriteLine($"Balance: ${balance}");
        }

        public abstract bool Withdraw(double value);

        public void Deposit(double value){
            Console.WriteLine($"${value} deposited with success.");
            balance += value;
        }

        public void Transfer(double value, Account target){
            if(this.Withdraw(value))
                target.Deposit(value);
            else   
                Console.WriteLine("Insufficient Funds. Transaction Interrupted.");
        }
    }
}