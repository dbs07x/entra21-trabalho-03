namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Crm { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
