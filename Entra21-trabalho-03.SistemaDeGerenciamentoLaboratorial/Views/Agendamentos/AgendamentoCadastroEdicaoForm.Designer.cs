namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Agendamentos
{
    partial class AgendamentoCadastroEdicaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendamentoCadastroEdicaoForm));
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUnidade = new System.Windows.Forms.ComboBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.comboBoxExame = new System.Windows.Forms.ComboBox();
            this.textBoxMedico = new System.Windows.Forms.TextBox();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelExame = new System.Windows.Forms.Label();
            this.labelMedico = new System.Windows.Forms.Label();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelObservacoes = new System.Windows.Forms.Label();
            this.labelPrecoLabel = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.label7.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(133, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "CADASTRO/EDIÇÃO:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(306, 529);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonCancelar.Size = new System.Drawing.Size(215, 57);
            this.buttonCancelar.TabIndex = 29;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.ForeColor = System.Drawing.Color.Black;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(12, 529);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(213, 57);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(12, 84);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerData.TabIndex = 31;
            // 
            // comboBoxUnidade
            // 
            this.comboBoxUnidade.FormattingEnabled = true;
            this.comboBoxUnidade.Location = new System.Drawing.Point(12, 260);
            this.comboBoxUnidade.Name = "comboBoxUnidade";
            this.comboBoxUnidade.Size = new System.Drawing.Size(506, 28);
            this.comboBoxUnidade.TabIndex = 32;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(12, 205);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(506, 28);
            this.comboBoxPaciente.TabIndex = 33;
            this.comboBoxPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaciente_SelectedIndexChanged);
            // 
            // comboBoxExame
            // 
            this.comboBoxExame.FormattingEnabled = true;
            this.comboBoxExame.Location = new System.Drawing.Point(12, 141);
            this.comboBoxExame.Name = "comboBoxExame";
            this.comboBoxExame.Size = new System.Drawing.Size(250, 28);
            this.comboBoxExame.TabIndex = 34;
            this.comboBoxExame.SelectedIndexChanged += new System.EventHandler(this.comboBoxExame_SelectedIndexChanged);
            // 
            // textBoxMedico
            // 
            this.textBoxMedico.Location = new System.Drawing.Point(268, 142);
            this.textBoxMedico.Name = "textBoxMedico";
            this.textBoxMedico.ReadOnly = true;
            this.textBoxMedico.Size = new System.Drawing.Size(250, 27);
            this.textBoxMedico.TabIndex = 37;
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.dateTimePickerHora.CustomFormat = "HH:mm";
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(268, 84);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerHora.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(63, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "*";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelData.Location = new System.Drawing.Point(12, 60);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(45, 21);
            this.labelData.TabIndex = 39;
            this.labelData.Text = "Data";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHora.Location = new System.Drawing.Point(268, 57);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(47, 21);
            this.labelHora.TabIndex = 41;
            this.labelHora.Text = "Hora";
            // 
            // labelExame
            // 
            this.labelExame.AutoSize = true;
            this.labelExame.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExame.Location = new System.Drawing.Point(12, 118);
            this.labelExame.Name = "labelExame";
            this.labelExame.Size = new System.Drawing.Size(59, 21);
            this.labelExame.TabIndex = 42;
            this.labelExame.Text = "Exame";
            // 
            // labelMedico
            // 
            this.labelMedico.AutoSize = true;
            this.labelMedico.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMedico.Location = new System.Drawing.Point(268, 118);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(65, 21);
            this.labelMedico.TabIndex = 43;
            this.labelMedico.Text = "Médico";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPaciente.Location = new System.Drawing.Point(12, 181);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(73, 21);
            this.labelPaciente.TabIndex = 44;
            this.labelPaciente.Text = "Paciente";
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnidade.Location = new System.Drawing.Point(11, 236);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(74, 21);
            this.labelUnidade.TabIndex = 45;
            this.labelUnidade.Text = "Unidade";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 315);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(506, 147);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelObservacoes.Location = new System.Drawing.Point(12, 291);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(103, 21);
            this.labelObservacoes.TabIndex = 47;
            this.labelObservacoes.Text = "Observações";
            // 
            // labelPrecoLabel
            // 
            this.labelPrecoLabel.AutoSize = true;
            this.labelPrecoLabel.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrecoLabel.Location = new System.Drawing.Point(72, 475);
            this.labelPrecoLabel.Name = "labelPrecoLabel";
            this.labelPrecoLabel.Size = new System.Drawing.Size(212, 28);
            this.labelPrecoLabel.TabIndex = 48;
            this.labelPrecoLabel.Text = "Preço agendamento:";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPreco.Location = new System.Drawing.Point(281, 471);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(143, 35);
            this.labelPreco.TabIndex = 49;
            this.labelPreco.Text = "R$ 1000,00";
            // 
            // AgendamentoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(533, 598);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelPrecoLabel);
            this.Controls.Add(this.labelObservacoes);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelUnidade);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.labelMedico);
            this.Controls.Add(this.labelExame);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.textBoxMedico);
            this.Controls.Add(this.comboBoxExame);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.comboBoxUnidade);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label7);
            this.Name = "AgendamentoCadastroEdicaoForm";
            this.Text = "AgendamentoCadastroEdicaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private DateTimePicker dateTimePickerData;
        private ComboBox comboBoxUnidade;
        private ComboBox comboBoxPaciente;
        private ComboBox comboBoxExame;
        private TextBox textBoxMedico;
        private DateTimePicker dateTimePickerHora;
        private Label label3;
        private Label labelData;
        private Label labelHora;
        private Label labelExame;
        private Label labelMedico;
        private Label labelPaciente;
        private Label labelUnidade;
        private RichTextBox richTextBox1;
        private Label labelObservacoes;
        private Label labelPrecoLabel;
        private Label labelPreco;
    }
}