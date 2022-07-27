using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Unidades;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views
{
    public partial class MenuForm : Form
    {
        private Form FormAtivo;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MostrarForm(Form form)
        {
            FecharFormAtivo();
            FormAtivo = form;
            form.TopLevel = false;
            panelForm.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void FecharFormAtivo()
        {
            if (FormAtivo != null)
                FormAtivo.Close();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            var unidadesForm = new UnidadeListagemForm();
            unidadesForm.TopLevel = false;
            unidadesForm.FormBorderStyle = FormBorderStyle.None;
            unidadesForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(unidadesForm);
            panelForm.Tag = unidadesForm;
            unidadesForm.BringToFront();
            unidadesForm.Show();
        }
    }
}
