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

           var nome = textBoxNome.Text.Trim();
           var tipoPlano = comboBox1.SelectedItem as Plano;

            var plano = new Plano();

         




            if (_idParaEditar == -1) 
            {
            
            
            }
        }


        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
