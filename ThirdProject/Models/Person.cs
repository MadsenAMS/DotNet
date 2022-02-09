using System;

namespace ThirdProject
{
    public class Person
    {
        protected string name;
        protected int age;
        
        public Person(string name = "John Doe", int age = 18){
            this.name = name;
            this.age = age;
        }

        public void Presentation(){
            Console.WriteLine($"Hi, my name is {name}, and I'm {age} years old.");
        }
    }
}