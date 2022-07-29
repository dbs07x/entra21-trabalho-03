using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal interface IAgendamentoService
    {
        void Cadastrar(Agendamento agendamento);
        void Editar(Agendamento agendamento);
        void Apagar(int id);
        Agendamento ObterPorId(int id);
        List<Agendamento> ObterTodosFiltrando(string pacientePesquisa, string unidadePesquisa);
    }
}
