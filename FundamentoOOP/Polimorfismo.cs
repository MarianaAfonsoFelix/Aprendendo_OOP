namespace FundamentoOOP
{
    public class Lampada : AparelhoIA
    {
        public Lampada(string nome, int voltagem)
            : base(nome, voltagem) { }

        public Lampada()
            : base("Padrao", 220) {  }

        private static void MudarCor() {}

        private static void ConfigurarTimer() {}

        public override void Configurar()
        {
            // Configurar Lampada
            Ligar();
            MudarCor();
            Desligar();
        }

        public override void Ligar()
        {
           // função ligar da Lampada
        }

        public override void Desligar()
        {
            // função desligar da Lampada
        }
    }
}