using System;

namespace PrimeiroProjeto.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade}");
        }
    }
}