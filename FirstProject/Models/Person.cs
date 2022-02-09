using System;

namespace FirstProject.Models
{
    public class Person
    {
        public string name {get;}
        public int age {get;}

        public Person(string name = "John Doe", int age = 18){
            this.name = name;
            this.age = age;
        }

        public void Presentation(){
            Console.WriteLine($"Hi, my name is {name}, and I'm {age} years old.");
        }
    }
}