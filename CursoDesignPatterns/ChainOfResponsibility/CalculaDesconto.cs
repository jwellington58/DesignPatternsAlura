using CursoDesignPatterns.ChainOfResponsibility.Descontos;

namespace CursoDesignPatterns.ChainOfResponsibility
{
    public class CalculaDesconto
    {
        public double Calcula(Orcamento orcamento) 
        {
            IDesconto d1 = new DescontoCincoItems();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }
}