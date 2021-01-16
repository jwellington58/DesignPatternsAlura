using System;

namespace CursoDesignPatterns.Investimentos
{
    public class Moderado : Investimento
    {
        public double Calcula(Orcamento orcamento)
        {
            var probabilidade = new Random().Next(101);
            if(probabilidade < 50)
            {
                return 0.75 * (orcamento.Valor * 0.025);
            }
            return 0.75 * (orcamento.Valor * 0.007);
            
        }
    }
}