namespace CursoDesignPatterns.ChainOfResponsibility.Descontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if(Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
                return orcamento.Valor * 0.05;
            return Proximo.Desconta(orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento) 
        {
            foreach (Item item in orcamento.Itens) 
            {
                if(item.Nome.Equals(nomeDoItem)) 
                    return true;
            }
            return false;
        }
    }
}