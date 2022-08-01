using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal interface IPacienteService
   {
        List<Paciente> ObterTodosFiltrando(string pacientePesquisa);
        Paciente ObterPorId(int id);
        void Cadastrar(Paciente paciente);
        void Editar(Paciente paciente);
        void Apagar(int id);

    }
}
