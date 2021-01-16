namespace CursoDesignPatterns.Investimentos
{
    public class Conservador : Investimento
    {
        public double Calcula(Orcamento orcamento)
        {
            return 0.75 * (orcamento.Valor * 0.008);
        }
    }
}