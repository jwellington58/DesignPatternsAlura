using System;

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
            
            calculador.RealizaCalculo(orcamento, iss);
        }
    }
}
