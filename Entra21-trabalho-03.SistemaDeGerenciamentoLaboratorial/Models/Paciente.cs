namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string Cpf { get; set; } 
        public string Telefone { get; set; }
        public string Email {get; set; }    

        public Plano Plano { get; set; }

    }
}
