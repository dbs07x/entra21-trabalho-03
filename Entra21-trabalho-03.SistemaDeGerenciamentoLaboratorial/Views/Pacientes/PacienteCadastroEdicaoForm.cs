using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Pacientes
{
    public partial class PacienteCadastroEdicaoForm : Form
    {

        private readonly int _idParaEditar;
        private readonly PacienteService _pacienteService;

        private DateTime dataNascimento;

        public PacienteCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxTipoPlano();

            _idParaEditar = -1;
        }

        public PacienteCadastroEdicaoForm(Paciente paciente) : this()
        {
            _idParaEditar = paciente.Id;

            textBoxNome.Text = paciente.Nome;
            textBoxEmail.Text = paciente.Email;
            maskedTextBoxCpf.Text = paciente.Cpf;
            maskedTextBoxTelefone.Text = paciente.Telefone;
            dateTimePicker1.Value = paciente.Data_nascimento;

            for (var i = 0; i < comboBoxPlano.Items.Count; i++) 
            {
                var tipoPlanoPercorrido = comboBoxPlano.Items[i] as Plano;

                if (tipoPlanoPercorrido.Id == paciente.Plano.Id) 
                {
                    comboBoxPlano.SelectedItem = tipoPlanoPercorrido;
                    break;
                }
            }
        }

        private void PreencherComboBoxTipoPlano()
        {
            var planoService = new PlanoService();
            var planos = planoService.ObterTodos();

            for (int i = 0; i < planos.Count; i++) 
            {

                var plano = planos[i];
                comboBoxPlano.Items.Add(plano);
            
            }
        }

        private void PacienteCadastroEdicaoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxPlano.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um plano");
                return;

            }

            var paciente = new Paciente();
            paciente.Nome = textBoxNome.Text.Trim();
            paciente.Email = textBoxEmail.Text.Trim();
            paciente.Data_nascimento = dateTimePicker1.Value;
            paciente.Cpf = maskedTextBoxCpf.Text.Trim().Replace(",", string.Empty).Replace("-", string.Empty);
            paciente.Telefone = maskedTextBoxTelefone.Text.Trim().Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty);
            paciente.Plano = comboBoxPlano.SelectedItem as Plano;

            var pacienteService = new PacienteService();

            if (_idParaEditar == -1)
            {
                pacienteService.Cadastrar(paciente);

                MessageBox.Show("Paciente cadastrado com sucesso");
                Close();
            }
            else
            {
                paciente.Id = _idParaEditar;
                pacienteService.Editar(paciente);

                MessageBox.Show("Paciente alterado com sucesso");
                Close();
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
