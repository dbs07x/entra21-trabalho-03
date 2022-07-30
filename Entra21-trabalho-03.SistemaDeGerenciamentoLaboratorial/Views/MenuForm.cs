using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Agendamentos;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Pacientes;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Planos;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Unidades;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views
{
    public partial class MenuForm : Form
    {
        private Form FormAtivo;
        private bool SidebarAtiva = true;

        public MenuForm()
        {
            InitializeComponent();

            BotaoAtivo(buttonDashboard);
            var dashboardForm = new DashboardForm();
            MostrarForm(dashboardForm);
        }

        private void MostrarForm(Form form)
        {
            FecharFormAtivo();
            FormAtivo = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void FecharFormAtivo()
        {
            if (FormAtivo != null)
                FormAtivo.Close();
        }

        private void BotaoAtivo(Button botaoAtivo)
        {
            for (int i = 0; i < flowLayoutPanelPrincipal.Controls.Count; i++)
            {
                var botao = flowLayoutPanelPrincipal.Controls[i];
                botao.BackColor = Color.FromArgb(((((byte)(177)))), ((((byte)(211)))), ((((byte)(75)))));
            }
            botaoAtivo.BackColor = Color.FromArgb(((((byte)(0)))), ((((byte)(153)))), ((((byte)(90)))));
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonDashboard);
            var dashboardForm = new DashboardForm();
            MostrarForm(dashboardForm);
        }

        private void buttonUnidades_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonUnidades);
            var unidadesForm = new UnidadeListagemForm();
            MostrarForm(unidadesForm);
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (SidebarAtiva)
            {
                flowLayoutPanelPrincipal.Width -= 10;
                if (flowLayoutPanelPrincipal.Width == flowLayoutPanelPrincipal.MinimumSize.Width)
                {
                    timerSidebar.Stop();
                    SidebarAtiva = false;
                }
            }
            else
            {
                flowLayoutPanelPrincipal.Width += 10;
                if (flowLayoutPanelPrincipal.Width == flowLayoutPanelPrincipal.MaximumSize.Width)
                {
                    timerSidebar.Stop();
                    SidebarAtiva = true;
                }
            }
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void buttonAgendamentos_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonAgendamentos);
            var agendamentoForm = new AgendamentoListagemForm();
            MostrarForm(agendamentoForm);
        }

        private void buttonPlanos_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonPlanos);
            var planosForm = new PlanoListagemForm();
            MostrarForm(planosForm);
        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonPlanos);
            var pacientesForm = new PacienteListagemForm();
            MostrarForm(pacientesForm);
        }
    }
}
