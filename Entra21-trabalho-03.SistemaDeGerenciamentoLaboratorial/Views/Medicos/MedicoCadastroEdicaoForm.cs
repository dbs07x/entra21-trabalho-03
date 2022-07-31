using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using System.Data.SqlClient;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Medicos
{
    public partial class MedicoCadastroEdicaoForm : Form
    {
        public readonly int _idParaEditar;

        private readonly MedicoService _medicoService;

        private const int modoCadastro = -1;
        public MedicoCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = modoCadastro;

            _medicoService = new MedicoService();
        }

        public MedicoCadastroEdicaoForm(Medico medico) : this()
        {
            _idParaEditar = medico.Id;

            textBoxNome.Text = medico.Nome;
            dateTimePickerDataNascimento.Value = medico.DataNascimento;
            maskedTextBoxCpf.Text = medico.Cpf;
            textBoxCrm.Text = medico.Crm;
            textBoxUf.Text = medico.Uf;
            maskedTextBoxTelefone.Text = medico.Telefone;
            textBoxEmail.Text = medico.Email;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var dataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Value.Date.ToString("dd/MM/yyyy"));
            var cpf = maskedTextBoxCpf.Text.Trim();
            var crm = textBoxCrm.Text.Trim();
            var uf = textBoxUf.Text.Trim();
            var telefone = maskedTextBoxTelefone.Text.Trim();
            var email = textBoxEmail.Text.Trim();

            if (ValidarInformacoes() == false)
                return;

            try
            {
                var medico = new Medico();
                medico.Nome = nome;
                medico.DataNascimento = dataNascimento;
                medico.Cpf = cpf;
                medico.Crm = crm;
                medico.Uf = uf;
                medico.Telefone = telefone;
                medico.Email = email;

                if (_idParaEditar == modoCadastro)
                    CadastrarCliente(medico);
                else
                    EditarCliente(medico);
            }
            catch (SqlException)
            {
                MessageBox.Show("Não foi possível salvar o médico");
            }
        }

        private void EditarCliente(Medico medico)
        {
            medico.Id = _idParaEditar;

            _medicoService.Editar(medico);

            MessageBox.Show("Médico editado com sucesso");

            Close();
        }

        private void CadastrarCliente(Medico medico)
        {
            _medicoService.Cadastrar(medico);

            MessageBox.Show("Médico cadastrado com sucesso");

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarInformacoes()
        {
            if (textBoxNome.Text.Trim().Length <= 3 || textBoxNome.Text.Trim().Length >= 30)
            {
                MessageBox.Show("O nome deve conter mais que 3 caracteres e menos que 30");
                textBoxNome.Focus();
                return false;
            }

            /*if (dateTimePickerDataNascimento < DateTime.Now)
            {
                MessageBox.Show("Data inválida");
                textBoxLogradouro.Focus();
                return false;
            }

            if (maskedTextBoxCpf.Text.Trim().Length != 11)
            {
                MessageBox.Show("O CPF deve conter 11 números");
                maskedTextBoxCpf.Focus();
                return false;
            }

            if (textBoxCrm.Text.Trim().Length != 6)
            {
                MessageBox.Show("O CRM deve conter 6 números");
                textBoxCrm.Focus();
                return false;
            }

            if (textBoxUf.Text.Trim().Length != 2)
            {
                MessageBox.Show("A unidade federativa deve conter 2 caracteres");
                textBoxUf.Focus();
                return false;
            }

            if (maskedTextBoxTelefone.Text.Trim().Length != 11)
            {
                MessageBox.Show("O telefone deve conter 11 números");
                maskedTextBoxTelefone.Focus();
                return false;
            }

            if (textBoxEmail.Text.Trim().Length < 11 || textBoxEmail.Text.Trim().Length > 30)
            {
                MessageBox.Show("O telefone deve conter 11 números");
                textBoxEmail.Focus();
                return false;
            }*/

            return true;
        }
    }
}
