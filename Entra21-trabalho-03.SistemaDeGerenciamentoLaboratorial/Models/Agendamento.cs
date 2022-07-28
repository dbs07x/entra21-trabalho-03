namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models
{
    internal class Agendamento
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataHora { get; set; }

        public Paciente Paciente { get; set; }
        public Exame Exame { get; set; }
        public Unidade Unidade { get; set; }
    }
}
