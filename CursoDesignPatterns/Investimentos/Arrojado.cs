using System;

namespace CursoDesignPatterns.Investimentos
{
    public class Arrojado : Investimento
    {
        public double Calcula(Orcamento orcamento)
        {
            var probabilidade = new Random().Next(101);
            if(probabilidade < 20)
            {
                return 0.75 * (orcamento.Valor * 0.05);
            }
            else if (probabilidade >= 20 && probabilidade < 50)
            {
                return 0.75 * (orcamento.Valor * 0.03);
            }
            return 0.75 * (orcamento.Valor * 0.06);
            
        }
    }
}