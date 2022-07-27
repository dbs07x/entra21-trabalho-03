using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views
{
    public partial class DashboardForm : Form
    {
        internal readonly DashboardService _dashboardService;

        public DashboardForm()
        {
            InitializeComponent();

            _dashboardService = new DashboardService();

            labelQuantidadeUnidades.Text = _dashboardService.ObterQuantidadeTabelas("unidades").ToString();
            labelQuantidadeMedicos.Text = _dashboardService.ObterQuantidadeTabelas("medicos").ToString();
            labelQuantidadePacientes.Text = _dashboardService.ObterQuantidadeTabelas("pacientes").ToString();
            labelQuantidadeExames.Text = _dashboardService.ObterQuantidadeTabelas("exames").ToString();
        }
    }
}
