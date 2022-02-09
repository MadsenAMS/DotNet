using ThirdProject.Models;

namespace ThirdProject.Models
{
    public class Student : Person
    {
        public Student(string name, int age){
            base.name = name;
            base.age = age;
        }
        public int grade {get; set;}
    }
}