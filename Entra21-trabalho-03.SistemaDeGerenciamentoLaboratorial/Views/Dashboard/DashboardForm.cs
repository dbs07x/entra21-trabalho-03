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
            labelMediaIdade.Text = ObterMediaPacientes().ToString() + " anos";
        }

        public double ObterMediaPacientes()
        {
            var pacienteService = new PacienteService();
            var pacientes = pacienteService.ObterTodosFiltrando("");
            var indice = 0;
            var soma = 0.0;

            while (indice < pacientes.Count)
            {
                var paciente = pacientes[indice];

                var idadePaciente = DateTime.Now.Year - paciente.Data_nascimento.Year;
                if (DateTime.Now.DayOfYear < paciente.Data_nascimento.DayOfYear)
                    idadePaciente--;

                soma += idadePaciente;

                indice++;
            }
            
            double media = soma / indice;

            return media;
        }


    }
}
