using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Unidades
{
    public partial class UnidadeCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        private readonly UnidadeService _unidadeService;

        private const int modoCadastro = -1;

        public UnidadeCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = modoCadastro;

            _unidadeService = new UnidadeService();
        }

        public UnidadeCadastroEdicaoForm(Unidade unidade) : this()
        {
            _idParaEditar = unidade.Id;

            textBoxNome.Text = unidade.Nome;
            maskedTextBoxCep.Text = unidade.Cep;
            textBoxLogradouro.Text = unidade.Logradouro;
            textBoxBairro.Text = unidade.Bairro;
            textBoxCidade.Text = unidade.Cidade;
            textBoxUf.Text = unidade.Uf;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var cep = maskedTextBoxCep.Text.Trim().Replace("-", string.Empty);
            var logradouro = textBoxLogradouro.Text.Trim();
            var bairro = textBoxBairro.Text.Trim();
            var cidade = textBoxCidade.Text.Trim();
            var uf = textBoxUf.Text.Trim();

            if (ValidarInformacoes() == false)
                return;

            try
            {
                var unidade = new Unidade();
                unidade.Nome = nome;
                unidade.Cep = cep;
                unidade.Logradouro = logradouro;
                unidade.Bairro = bairro;
                unidade.Cidade = cidade;
                unidade.Uf = uf;

                if (_idParaEditar == modoCadastro)
                    CadastrarCliente(unidade);
                else
                    EditarCliente(unidade);
            }
            catch (SqlException)
            {
                MessageBox.Show("Não foi possível salvar a unidade");
            }
        }

        private void EditarCliente(Unidade unidade)
        {
            unidade.Id = _idParaEditar;

            _unidadeService.Editar(unidade);

            MessageBox.Show("Cliente editado com sucesso");

            Close();
        }

        private void CadastrarCliente(Unidade unidade)
        {
            _unidadeService.Cadastrar(unidade);

            MessageBox.Show("Cliente cadastrado com sucesso");

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", string.Empty).Trim();

            if (cep.Length != 8)
                return;

            var httpCliente = new HttpClient();

            var resultado = httpCliente.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);
                
                if (dadosEndereco.Erro == true)
                {
                    MessageBox.Show("O CEP digitado não existe");

                    maskedTextBoxCep.Focus();

                    return;
                }

                textBoxLogradouro.Text = dadosEndereco.Logradouro;
                textBoxBairro.Text = dadosEndereco.Bairro;
                textBoxCidade.Text = dadosEndereco.Localidade;
                textBoxUf.Text = dadosEndereco.Uf;
            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private bool ValidarInformacoes()
        {
            if (textBoxNome.Text.Trim().Length <= 3 || textBoxNome.Text.Trim().Length >= 30)
            {
                MessageBox.Show("O nome deve conter mais que 3 caracteres e menos que 30");
                textBoxNome.Focus();
                return false;
            }

            if (textBoxLogradouro.Text.Trim().Length <= 3 || textBoxLogradouro.Text.Trim().Length >= 30)
            {
                MessageBox.Show("O logradouro deve conter mais que 3 caracteres e menos que 30");
                textBoxLogradouro.Focus();
                return false;
            }

            if (textBoxBairro.Text.Trim().Length <= 3 || textBoxBairro.Text.Trim().Length >= 30)
            {
                MessageBox.Show("O bairro deve conter mais que 3 caracteres e menos que 30");
                textBoxBairro.Focus();
                return false;
            }

            if (textBoxCidade.Text.Trim().Length <= 3 || textBoxCidade.Text.Trim().Length >= 30)
            {
                MessageBox.Show("A cidade deve conter mais que 3 caracteres e menos que 30");
                textBoxCidade.Focus();
                return false;
            }

            if (textBoxUf.Text.Trim().Length != 2)
            {
                MessageBox.Show("A unidade federativa deve conter 2 caracteres");
                textBoxUf.Focus();
                return false;
            }

            return true;
        }
    }
}
