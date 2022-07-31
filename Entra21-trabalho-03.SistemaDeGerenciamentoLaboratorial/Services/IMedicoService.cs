using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal interface IMedicoService
    {
        List<Medico> ObterTodosFiltrando(string nomePesquisa);
        Medico ObterPorId(int id);
        void Cadastrar(Medico medico);
        void Editar(Medico medico);
        void Apagar(int id);
    }
}
