using A_FirstProject.Models;

namespace A_FirstProject{

    public class Program{

        public static void Main(String[] args){
            Person cliente = new Person("Bob Martin", 62);
            cliente.Presentation();
        }
    }

}