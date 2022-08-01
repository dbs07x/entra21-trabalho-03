using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            var planoPesquisa = textBox1.Text;

            var planos = _planoService.ObterTodosFiltrando(planoPesquisa);

            dataGridView1.Rows.Clear();

            var cultura = new CultureInfo("pt-BR");
            cultura.NumberFormat.NumberDecimalSeparator = ",";
            cultura.NumberFormat.CurrencyGroupSeparator = ".";
            cultura.NumberFormat.NumberDecimalDigits = 2;

            for (var i = 0; i < planos.Count; i++)
            {
                var plano = planos[i];

                dataGridView1.Rows.Add(new object[]
                   {
                   plano.Id,
                   plano.Nome,
                   plano.Abrangencia,
                   plano.Acomodacao,
                   plano.Coparticipacao * 100 + "%",
                   string.Format(cultura, "R$ {0:N}", plano.Preco)
                   });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var planoForm = new PlanoCadastroEdicaoForm();
            planoForm.ShowDialog();

            PreencherDataGridViewComPlanos();
        }

        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            var planoForm = new PlanoCadastroEdicaoForm();
            planoForm.ShowDialog();

            PreencherDataGridViewComPlanos();

        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
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

        private void buttonApagar_Click_1(object sender, EventArgs e)
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
                try
                {
                    var linhaSelecionada = dataGridView1.SelectedRows[0];

                    var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                    _planoService.Apagar(id);

                    PreencherDataGridViewComPlanos();

                    MessageBox.Show("Plano removido com sucesso", "Aviso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível apagar o plano, provavelmente pois um paciente está o utilizando");
                }


            }
        }
    }
}
