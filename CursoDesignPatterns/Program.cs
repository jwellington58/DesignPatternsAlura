using System;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new ICMS();
            Imposto iss = new ISS();

            Orcamento orcamento = new Orcamento(500.00);
            CalculadorImposto calculador = new CalculadorImposto();
            
            // calculador.RealizaCalculo(orcamento, iss);

            RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();
            Investimento moderado = new Moderado();
            Console.WriteLine(orcamento.Valor);
            realizadorDeInvestimentos.RealizaInvestimento(orcamento, moderado);
            Console.ReadKey();
        }
    }
}
