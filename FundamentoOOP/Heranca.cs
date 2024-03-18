namespace FundamentoOOP
{
    public class Caminhonete : Carro
    {
        public DateTime DataCompra { get; set; }
        public string Comprador { get; set; }
    }

    public class ProcessoCompra
    {
        public void Compra()
        {
            var compra = new Caminhonete()
            {
                Cor = "Azul",
                DataCompra = DateTime.Now,
                AnoLancamento = 2015,
                Comprador = "Mariana Afonso"
            };

            if(compra.VerificaCarroNovo())
                Console.WriteLine("O carro é novo.");
            else
                Console.WriteLine("O carro é velho.");
        }
    }
}