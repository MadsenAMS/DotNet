namespace D_FourthProject.Models
{
    public class SavingsAccount : Account
    {
        
        public SavingsAccount(int accountNumber) : base(accountNumber){}

        public override bool Withdraw(double value){
            if(base.balance > value + 5){
                base.balance -= value + 5;
                Console.WriteLine($"${value} was withdrawn. An additional $5.00 withdrawal fee was charged.");
                return true;
            }else{
                return false;
            }
        }
    }
}