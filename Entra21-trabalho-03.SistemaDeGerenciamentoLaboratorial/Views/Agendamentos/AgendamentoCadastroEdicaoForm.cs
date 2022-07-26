﻿using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Agendamentos
{
    public partial class AgendamentoCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        private readonly AgendamentoService _agendamentoService;

        private const int modoCadastro = -1;

        private double ValorExame = 0;
        private decimal ValorCoparticipacao = 0;

        public AgendamentoCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = modoCadastro;

            _agendamentoService = new AgendamentoService();

            PreencherComBoxExame();
            PreencherComBoxPaciente();
            PreencherComBoxUnidade();
        }

        public AgendamentoCadastroEdicaoForm(Agendamento agendamento) : this()
        {
            _idParaEditar = agendamento.Id;

            dateTimePickerData.Value = agendamento.DataHora;
            dateTimePickerHora.Value = Convert.ToDateTime(agendamento.DataHora.ToString("HH:mm"));
            textBoxMedico.Text = agendamento.Exame.Medico.Nome;
            labelPreco.Text = "R$ " + agendamento.Preco.ToString();

            for (int i = 0; i < comboBoxExame.Items.Count; i++)
            {
                var examePercorrido = comboBoxExame.Items[i] as Exame;

                if (examePercorrido.Id == agendamento.Exame.Id)
                {
                    comboBoxExame.SelectedItem = examePercorrido;
                    break;
                }
            }     
            
            for (int i = 0; i < comboBoxPaciente.Items.Count; i++)
            {
                var pacientePercorrido = comboBoxPaciente.Items[i] as Paciente;

                if (pacientePercorrido.Id == agendamento.Paciente.Id)
                {
                    comboBoxPaciente.SelectedItem = pacientePercorrido;
                    break;
                }
            } 
            
            for (int i = 0; i < comboBoxUnidade.Items.Count; i++)
            {
                var unidadePercorrida = comboBoxUnidade.Items[i] as Unidade;

                if (unidadePercorrida.Id == agendamento.Unidade.Id)
                {
                    comboBoxUnidade.SelectedItem = unidadePercorrida;
                    break;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var agendamento = new Agendamento();
            agendamento.DataHora = Convert.ToDateTime($"{dateTimePickerData.Value.Date.ToString("dd/MM/yyyy")} {dateTimePickerHora.Value.TimeOfDay}");
            agendamento.Preco = Convert.ToDecimal(labelPreco.Text.Replace("R$ ", string.Empty));
            agendamento.Paciente = comboBoxPaciente.SelectedItem as Paciente;
            agendamento.Unidade = comboBoxUnidade.SelectedItem as Unidade;
            agendamento.Exame = comboBoxExame.SelectedItem as Exame;

            if (ValidarInformacoes() == false)
                return;

            if (_idParaEditar == -1)
            {
                _agendamentoService.Cadastrar(agendamento);

                MessageBox.Show("Agendamento cadastrado com sucesso");
                Close();
            }
            else
            {
                agendamento.Id = _idParaEditar;

                _agendamentoService.Editar(agendamento);

                MessageBox.Show("Agendamento editado com sucesso");
                Close();
            }
        }

        private void PreencherComBoxPaciente()
        {
            var pacienteService = new PacienteService();
            var pacientes = pacienteService.ObterTodosFiltrando("");

            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente);
            }
        }
        
        private void PreencherComBoxExame()
        {
            var exameService = new ExameService();
            var exames = exameService.ObterTodosFiltrando("");

            for (int i = 0; i < exames.Count; i++)
            {
                var exame = exames[i];
                comboBoxExame.Items.Add(exame);
            }
        }        

        private void PreencherComBoxUnidade()
        {
            var unidadeService = new UnidadeService();
            var unidades = unidadeService.ObterTodosFiltrando("");

            for (int i = 0; i < unidades.Count; i++)
            {
                var unidade = unidades[i];
                comboBoxUnidade.Items.Add(unidade);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxExame_SelectedIndexChanged(object sender, EventArgs e)
        {
            var exameService = new ExameService();
            var exameSelecionado = comboBoxExame.SelectedItem as Exame;
            var exame = exameService.ObterPorId(exameSelecionado.Id);
            textBoxMedico.Text = exame.Medico.Nome;

            ValorExame = exameSelecionado.Preco;

            CalcularPreco();
        }

        private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pacienteSelecionado = comboBoxPaciente.SelectedItem as Paciente;
            ValorCoparticipacao = pacienteSelecionado.Plano.Coparticipacao;

            CalcularPreco();
        }

        private void CalcularPreco()
        {
            var valor = ValorExame * Convert.ToDouble(ValorCoparticipacao);
            labelPreco.Text = "R$ " + valor.ToString();
        }

        private bool ValidarInformacoes()
        {
            if (comboBoxExame.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um exame");
                comboBoxExame.Focus();
                return false;
            }      
            
            if (comboBoxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um paciente");
                comboBoxPaciente.Focus();
                return false;
            }      
            
            if (comboBoxUnidade.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma unidade");
                comboBoxUnidade.Focus();
                return false;
            }

            if (dateTimePickerHora.Value.Hour > 18 || dateTimePickerHora.Value.Hour < 6)
            {
                MessageBox.Show("Não é possível marcar uma consulta antes das 6h e depois das 18h");
                dateTimePickerHora.Focus();
                return false;
            }

            return true;
        }
    }
}
