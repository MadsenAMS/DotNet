using G_SeventhProject.Models;

namespace G_SeventhProject{

    class Program{
        public delegate void Operation(int x, int y);

        public static void Main(string[] args){
            Operation addition = new Operation(Calculator.Add);
            Operation subtraction = new Operation(Calculator.Subtract);
            Operation multiplication = new Operation(Calculator.Multiply);
            Operation division = new Operation(Calculator.Divide);

            addition(2, 3);
            subtraction(2, 3);
            multiplication(2,3);
            division(2,3);

            //Multicast Delegate. Neat stuff.
            Operation calculate = new Operation(Calculator.Add);
            calculate += Calculator.Subtract;
            calculate += Calculator.Multiply;
            calculate += Calculator.Divide;

            calculate(2,3);
        }
    }
}


