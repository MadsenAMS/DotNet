namespace G_SeventhProject.Models
{
    public class Calculator
    {
        public static void Add(int x, int y){
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public static void Subtract(int x, int y){
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public static void Multiply(int x, int y){
            Console.WriteLine($"{x} x {y} = {x*y}");
        }

        public static void Divide(int x, int y){
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
    }
}