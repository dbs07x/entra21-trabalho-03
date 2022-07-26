﻿using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using System.Data.SqlClient;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Pacientes
{
    public partial class PacienteListagemForm : Form
    {
        internal readonly PacienteService _pacienteService;

        public PacienteListagemForm()
        {
            InitializeComponent();

            _pacienteService = new PacienteService();

            PreencherDataGridViewComPacientes();

        }

        private void PreencherDataGridViewComPacientes()
        {
            var nomePesquisa = textBoxNomeFiltrar.Text;

            var pacientes = _pacienteService.ObterTodosFiltrando(nomePesquisa);

            dataGridView1.Rows.Clear();

            for (var i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Id,
                    paciente.Nome,
                    paciente.Data_nascimento.ToString("dd/MM/yyyy"),
                    paciente.Cpf.Substring(0, 3) + "." + paciente.Cpf.Substring(2, 3) + "." + paciente.Cpf.Substring(4, 3) + "-" + paciente.Cpf.Substring(7, 2),
                    paciente.Telefone,
                    paciente.Email
                });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var pacienteForm = new PacienteCadastroEdicaoForm();
            pacienteForm.ShowDialog();

            PreencherDataGridViewComPacientes();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDataGridViewComPacientes();
        }

        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            var pacienteForm = new PacienteCadastroEdicaoForm();
            pacienteForm.ShowDialog();

            PreencherDataGridViewComPacientes();
        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente para editar", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var paciente = _pacienteService.ObterPorId(id);

            var pacienteCadastroForm = new PacienteCadastroEdicaoForm(paciente);

            pacienteCadastroForm.ShowDialog();

            PreencherDataGridViewComPacientes();
        }

        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente para apagar!", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var resposta = MessageBox.Show("Deseja apagar o paciente?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("O paciente não foi removido", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    var linhaSelecionada = dataGridView1.SelectedRows[0];

                    var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                    _pacienteService.Apagar(id);

                    PreencherDataGridViewComPacientes();

                    MessageBox.Show("Paciente removido com sucesso!", "Aviso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível apagar o registro, provavelmente porque está sendo usado em um agendamento");
                }

            }
        }
    }
}
