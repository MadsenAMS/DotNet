namespace FourthProject.Models
{
    public class CurrentAccount : Account
    {

        public CurrentAccount(int accountNumber) : base(accountNumber){}

        public override bool Withdraw(double value){
            if(base.balance > value + 1){
                base.balance -= value + 1;
                Console.WriteLine($"${value} was withdrawn. An additional $1.00 withdrawal fee was charged.");
                return true;
            }else{
                return false;
            }
        }
    }
}