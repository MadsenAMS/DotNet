using SecondProject.Models;
using System;

namespace SecondProject{
    public class Program{

       public static void Main(String[] args){
            Console.WriteLine("\nRectangle 1: Dimension 7, 8");
            Rectangle rectangle1 = new Rectangle(7, 8);
            rectangle1.Area();

            Console.WriteLine("\nRectangle 2: Dimension -2, 5");
            Rectangle rectangle2 = new Rectangle(-2, 5);
            rectangle2.Area();
        }
    }
}
