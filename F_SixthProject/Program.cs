using F_SixthProject.Models;

namespace F_SixthProject{

    class Program{

        static void Main(string[] args){

            SingletonDummy singleton = SingletonDummy.GetSingletonDummy();
            singleton.DummyMethod();
            singleton.DummyVar = "Hello There! Ah... General Kenobi!";
        }

    }

}