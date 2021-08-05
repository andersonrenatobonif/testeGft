namespace Teste2.src.Entities
{
    public class HospedagemVIP : Hospedagem
    {
        public HospedagemVIP(int Valor, string Nome, int Data, int valorAdicional, int Total ) : base(Valor, Nome, Data)
        {
            this.Valor = Valor;
            this.Nome = Nome;
            this.Data = Data;
            this.valorAdicional = valorAdicional;
            this.Total = Valor + valorAdicional;

        }

        public int valorAdicional;
        public int Total;

        public  int ValorTotal()
        {
            return Total; 
        }

       
    }
}