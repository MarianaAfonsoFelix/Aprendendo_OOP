namespace FundamentoOOP
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoLancamento { get; set; }

        //Regra carro novo, até 2 anos é novo
        public bool VerificaCarroNovo()
    {
        // Obtém o ano atual
        int anoAtual = DateTime.Now.Year;

        // Define o critério para determinar se o carro é novo ou velho
        int anosParaSerNovo = 3; // Exemplo: considera-se um carro novo se tiver até 3 anos de idade

        // Calcula a diferença entre o ano atual e o ano do carro
        int diferencaAnos = anoAtual - AnoLancamento;

        // Retorna true se o carro for novo, false caso contrário
        return diferencaAnos <= anosParaSerNovo;
    }
    }
}