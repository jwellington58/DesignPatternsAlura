using System;

namespace CursoDesignPatterns
{
    public class CalculadorImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
          Console.WriteLine(imposto.Calcula(orcamento));
        }
    }
}