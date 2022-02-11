using F_SixthProject.Models;

namespace F_SixthProject{

    class Program{

        static void Main(string[] args){

            SingletonDummy singleton = SingletonDummy.GetSingletonDummy();
            singleton.DummyMethod();
        }

    }

}