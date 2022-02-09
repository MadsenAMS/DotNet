using PrimeiroProjeto.Models;

public class Program{

    public static void Main(String[] args){
        Pessoa cliente = new Pessoa();
        cliente.Nome = "Bob Martin";
        cliente.Idade = 62;
        cliente.Apresentar();
    }
}


