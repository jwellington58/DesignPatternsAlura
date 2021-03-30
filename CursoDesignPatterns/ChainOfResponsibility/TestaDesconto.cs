using System;

namespace CursoDesignPatterns.ChainOfResponsibility
{
    public class TestaDesconto
    {
  
        public static void Teste() 
        {
            CalculaDesconto calculador = new CalculaDesconto();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
        }

    }
}