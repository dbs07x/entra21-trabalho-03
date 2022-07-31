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

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Planos
{
    public partial class PlanoCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public PlanoCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }

        public PlanoCadastroEdicaoForm(Plano plano) : this()
        {
            _idParaEditar = plano.Id;
            textBoxAbrangencia.Text = plano.Abrangencia;
            textBoxAcomodacao.Text = plano.Acomodacao;
            textBoxNome.Text = plano.Nome;
            textBoxPreco.Text = plano.Preco.ToString();
            textBoxCoparticipacao.Text = (plano.Coparticipacao * 100).ToString();

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var abrangencia = textBoxAbrangencia.Text.Trim();
            var acomodacao = textBoxAcomodacao.Text.Trim();
            var coparticipacao = textBoxCoparticipacao.Text.Trim();
            var preco = textBoxPreco.Text.Trim();

            var plano = new Plano();
            plano.Nome = nome;
            plano.Coparticipacao = Convert.ToDecimal(coparticipacao);
            plano.Preco = Convert.ToDecimal(preco);
            plano.Abrangencia = abrangencia;
            plano.Acomodacao = acomodacao;


            var planoService = new PlanoService();

            if (_idParaEditar == -1)
            {
                planoService.Cadastrar(plano);
                MessageBox.Show("Plano cadastrado com sucesso", "Aviso", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                plano.Id = _idParaEditar;
                planoService.Editar(plano);

                MessageBox.Show("Plano alterado com sucesso");
                Close();

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
