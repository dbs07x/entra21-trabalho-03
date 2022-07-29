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

            for (var i = 0; i < comboBox1.Items.Count; i++) 
            {

                var tipoPacientePercorrido = comboBox1.Items[i] as Paciente;

                if (tipoPacientePercorrido.Id == paciente.Id) 
                {

                    comboBox1.SelectedItem = tipoPacientePercorrido;
                
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
                comboBox1.Items.Add(plano);
            
            }
        }

        private void PacienteCadastroEdicaoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) 
            {
                MessageBox.Show("Selecione um plano");
                return;

            }

            var paciente = new Paciente();
           var nome = textBoxNome.Text.Trim();
           var email = textBoxEmail.Text.Trim();
            // var dataNascimento = dateTimePicker1
            var cpf = maskedTextBox1.Text.Trim();
            var telefone = maskedTextBox1.Text.Trim();
           var tipoPlano = comboBox1.SelectedItem as Plano;

            var pacienteService = new PacienteService();

            if (_idParaEditar == -1)
            {
                pacienteService.Cadastrar(paciente);

                MessageBox.Show("Paciente cadastrado com sucesso");
            }
            else 
            {
                paciente.Id = _idParaEditar;
                pacienteService.Editar(paciente);

                MessageBox.Show("Paciente alterado com sucesso");
                Close();                     
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
