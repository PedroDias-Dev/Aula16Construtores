using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // sem argumento
            Produto sapato = new Produto();
            sapato.Nome = "Vizzano";

            //1 argumento
            Produto chinelo = new Produto(45);
            Console.WriteLine(chinelo.Codigo);

            // todos os argumentos
            Produto camisa = new Produto(34, "Bape", "Roxa Camo", 984);
            Console.WriteLine(camisa.Codigo);
            Console.WriteLine(camisa.Estoque);
            Console.WriteLine(camisa.Descricao);
            Console.WriteLine(camisa.Nome);

        }
    }
}
