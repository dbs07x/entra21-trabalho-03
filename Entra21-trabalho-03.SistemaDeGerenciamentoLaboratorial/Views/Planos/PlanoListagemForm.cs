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

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Planos
{
    public partial class PlanoListagemForm : Form
    {
        private readonly PlanoService _planoService;

        public PlanoListagemForm()
        {
            InitializeComponent();

            _planoService = new PlanoService();

            PreencherDataGridViewComPlanos();

        }

        private void PreencherDataGridViewComPlanos()
        {
            var planos = _planoService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (var i = 0; i < planos.Count; i++)
            {
                var plano = planos[i];

                dataGridView1.Rows.Add(new object[]
                   {
                   plano.Id,
                   plano.Abrangencia,
                   plano.Acomodacao,
                   plano.Coparticipacao,
                   plano.Preco
                   });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um plano para apagar", "Aviso", MessageBoxButtons.OK);
                return; 
            }

            var resposta = MessageBox.Show("Deseja apagar o plano selecionado?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("O plano permanece listado", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                _planoService.Apagar(id);

                PreencherDataGridViewComPlanos();

                MessageBox.Show("Plano removido com sucesso", "Aviso", MessageBoxButtons.OK);

            
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um plano para editar", "Aviso", MessageBoxButtons.OK);
                return;
            }
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var plano = _planoService.ObterPorId(id);

            var planoCadastroForm = new PlanoCadastroEdicaoForm(plano);

            planoCadastroForm.ShowDialog();

            PreencherDataGridViewComPlanos();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var planoForm = new PlanoCadastroEdicaoForm();
            planoForm.ShowDialog();

            PreencherDataGridViewComPlanos();
        }
    }
}
