namespace ThirdProject.Models
{
    public class Teacher : Person
    {
         public Teacher(string name, int age){
            base.name = name;
            base.age = age;
        }
        public double salary {get; set;}
    }
}