namespace FundamentoOOP
{
    public abstract class AparelhoIA
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected AparelhoIA(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();
        public virtual void Configurar()
        {
            //configurar Aparelho
        }
    }
}