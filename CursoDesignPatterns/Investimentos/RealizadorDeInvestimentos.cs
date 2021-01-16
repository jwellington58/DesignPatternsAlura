using System;

namespace CursoDesignPatterns.Investimentos
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(Orcamento orcamento, Investimento investimento)
        {
            Console.WriteLine("O retorno do investimento eh: " + investimento.Calcula(orcamento));
        }
    }
}