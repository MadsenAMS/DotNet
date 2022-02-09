using System;

namespace SecondProject.Models
{
    public class Rectangle
    {
        private double width;
        private double height;
        private bool valid = false;

        public Rectangle(double width, double height){
            this.width = width;
            this. height = height;

            if(width > 0 && height > 0)
                valid = true;

            if(!valid){
                Console.WriteLine("Invalid Rectangle Dimensions.");
            }
        }

        public void Area(){
            if(valid)
                Console.WriteLine($"Height = {height}\nWidth = {width}\nArea = {width * height}");
            else
                Console.WriteLine("Invalid Rectangle Dimensions.");
        }
    }
}