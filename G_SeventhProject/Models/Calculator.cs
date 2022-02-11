namespace G_SeventhProject.Models
{
    public class Calculator
    {

        public delegate void DelegateCalculator();

        public static event DelegateCalculator EventCalculatorUsed;

        public static void Add(int x, int y)
        {
            if (Battery.charges > 0)
                Console.WriteLine($"{x} + {y} = {x + y}");
            else
                Console.WriteLine("Battery Low");
            TriggerEvent();
        }

        public static void Subtract(int x, int y)
        {
            if (Battery.charges > 0)
                Console.WriteLine($"{x} - {y} = {x - y}");
            else
                Console.WriteLine("Battery Low");
            TriggerEvent();
        }

        public static void Multiply(int x, int y)
        {
            if (Battery.charges > 0)
                Console.WriteLine($"{x} x {y} = {x * y}");
            else
                Console.WriteLine("Battery Low");
            TriggerEvent();
        }

        public static void Divide(int x, int y)
        {
            if (Battery.charges > 0)
                Console.WriteLine($"{x} / {y} = {x / y}");
            else
                Console.WriteLine("Battery Low");
            TriggerEvent();
        }

        private static void TriggerEvent()
        {
            if (EventCalculatorUsed != null)
                EventCalculatorUsed();
            else
                Console.WriteLine("No subscriptions to event");
        }

    }
}