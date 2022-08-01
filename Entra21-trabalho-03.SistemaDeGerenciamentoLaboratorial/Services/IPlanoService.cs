using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal interface IPlanoService
    {
        List<Plano> ObterTodosFiltrando(string planoPesquisa);
        Plano ObterPorId(int id);
        void Cadastrar(Plano plano);
        void Editar(Plano plano);
        void Apagar(int id);
    }
}
