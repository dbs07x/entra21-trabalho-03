using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Unidades;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuForm());
        }
    }
}