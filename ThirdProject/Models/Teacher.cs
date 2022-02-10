namespace ThirdProject.Models
{
    public class Teacher : Person
    {
         public Teacher(string name, int age) : base (name, age) {}
        public double salary {get; set;}

        public override void Presentation()
        {
            base.Presentation();
            Console.WriteLine($"I'm a teacher, and I make ${salary} a month.");
        }
    }
}