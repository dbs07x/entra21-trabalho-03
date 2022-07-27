namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models
{
    public class Exame
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Instrucoes { get; set; }
        public Medico Medico { get; set; }
    }
}
