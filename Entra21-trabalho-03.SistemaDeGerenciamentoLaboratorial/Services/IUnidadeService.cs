using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal interface IUnidadeService
    {
        void Cadastrar(Unidade unidade);
        void Editar(Unidade unidade);
        List<Unidade> ObterTodos();
        void Apagar(int id);
        Unidade ObterPorId(int id);
    }
}
