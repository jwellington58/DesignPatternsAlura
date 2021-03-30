namespace CursoDesignPatterns.ChainOfResponsibility.Descontos
{
    public interface IDesconto
    {
         public IDesconto Proximo {get; set; }
         public double Desconta(Orcamento orcamento);
    }
}