namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Pacientes
{
    partial class PacienteCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button buttonSalvar;
        private Button button1;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelNome;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label labelTelefone;
        private Label labelEmail;
        private TextBox textBox1;
        private ComboBox comboBoxPlano;
        private MaskedTextBox maskedTextBox1;
        private Label labelCpf;
        private DateTimePicker dateTimePicker1;
        private Label labelDataNascimento;
    }
}