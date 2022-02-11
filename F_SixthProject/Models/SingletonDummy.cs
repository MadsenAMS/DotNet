using System;

namespace F_SixthProject.Models
{
    public class SingletonDummy
    {
        private SingletonDummy(){

        }

        public static SingletonDummy singletonDummy;

        private string dummyVar = "";
        public string DummyVar {

            get{
                return this.dummyVar;
            }

            set{
                if(value.Length >= 3){
                    this.dummyVar = value;
                    Console.WriteLine($"DummyVar set to {value}");
                  }else{
                    Console.WriteLine("DummyVar must have at least 3 chars");
                }
            }
        }

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