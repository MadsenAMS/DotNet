using ThirdProject.Models;

namespace ThirdProject
{
    class Program{

        static void Main(string[] args){

        Student aluno = new Student("Sarah Lu", 27);
        aluno.grade = 100;
        aluno.Presentation();

        Teacher teacher = new Teacher("Joseph Climber", 55);
        teacher.salary = 6500;
        teacher.Presentation();        
        }

    }
}