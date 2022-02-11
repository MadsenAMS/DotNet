using System;

namespace F_SixthProject.Models
{
    public class SingletonDummy
    {
        private SingletonDummy(){

        }

        public static SingletonDummy singletonDummy;

        public static SingletonDummy GetSingletonDummy(){
            if(singletonDummy == null)
                singletonDummy = new SingletonDummy();
            
            return singletonDummy;
        }

        public void DummyMethod(){
            Console.WriteLine("Dummy method ping!");
        }
    }
}