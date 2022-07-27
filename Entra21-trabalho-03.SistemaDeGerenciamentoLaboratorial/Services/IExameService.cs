using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal interface IExameService
    {
        List<Exame> ObterTodos();
        Exame ObterPorId(int id);
        void Cadastrar(Exame exame);
        void Editar(Exame exame);
        void Apagar(int id);
    }
}
