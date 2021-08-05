namespace Teste2.src.Entities
{
    public class Hospedagem
    {
        public Hospedagem (int Valor, string Nome, int Data)
        {
            this.Valor = Valor;
            this.Nome = Nome;
            this.Data = Data;

        }

        public int Valor;
        public string Nome;
        public int Data;


          public virtual int printValor()
        {
            return this.Valor;
        }
    }
}