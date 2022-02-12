using System.Collections.Generic;
using System.Linq;
using System;

namespace H_EigthProject{
    class Program{
        static void Main(string[] args){

            List<int> dummyValues = new List<int>();

            for(int i = 0; i < 20; i++){
                dummyValues.Add(i);
            }

            List<int> evenDummyValues = 
                (
                from value in dummyValues
                where value % 2 == 0
                orderby value
                select value
                ).ToList();

            List<int>  oddDummyValues = 
                (
                from value in dummyValues
                where value % 2 != 0
                orderby value
                select value
                ).ToList();

            Console.WriteLine("Original DummyValues List = ");
            Console.Write("[");
            foreach(int item in dummyValues){
                Console.Write($" {item} ");
            }
            Console.Write("]");

            Console.WriteLine("\nEven DummyValues List = ");
            Console.Write("[");
            foreach(int item in evenDummyValues){
                Console.Write($" {item} ");
            }
            Console.Write("]");

            Console.WriteLine("\nOdd DummyValues List = ");
            Console.Write("[");
            foreach(int item in oddDummyValues){
                Console.Write($" {item} ");
            }
            Console.Write("]");

            Console.WriteLine($"\nMax DummyValues = {dummyValues.Max()}");
            Console.WriteLine($"Min DummyValues = {dummyValues.Min()}");
            Console.WriteLine($"Average DummyValues = {dummyValues.Average()}");
        }

    }
}