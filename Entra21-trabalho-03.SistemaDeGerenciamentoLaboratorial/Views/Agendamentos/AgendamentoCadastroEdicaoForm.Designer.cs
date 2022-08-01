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
            this.labelPrecoLabel = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.label7.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(116, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 27);
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
            this.buttonCancelar.Location = new System.Drawing.Point(269, 268);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.buttonCancelar.Size = new System.Drawing.Size(188, 43);
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
            this.buttonSalvar.Location = new System.Drawing.Point(22, 268);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(186, 43);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(10, 63);
            this.dateTimePickerData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerData.TabIndex = 31;
            // 
            // comboBoxUnidade
            // 
            this.comboBoxUnidade.DisplayMember = "Nome";
            this.comboBoxUnidade.FormattingEnabled = true;
            this.comboBoxUnidade.Location = new System.Drawing.Point(10, 200);
            this.comboBoxUnidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUnidade.Name = "comboBoxUnidade";
            this.comboBoxUnidade.Size = new System.Drawing.Size(443, 23);
            this.comboBoxUnidade.TabIndex = 32;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.DisplayMember = "Nome";
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(10, 154);
            this.comboBoxPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(443, 23);
            this.comboBoxPaciente.TabIndex = 33;
            this.comboBoxPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaciente_SelectedIndexChanged);
            // 
            // comboBoxExame
            // 
            this.comboBoxExame.DisplayMember = "Nome";
            this.comboBoxExame.FormattingEnabled = true;
            this.comboBoxExame.Location = new System.Drawing.Point(10, 106);
            this.comboBoxExame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxExame.Name = "comboBoxExame";
            this.comboBoxExame.Size = new System.Drawing.Size(219, 23);
            this.comboBoxExame.TabIndex = 34;
            this.comboBoxExame.SelectedIndexChanged += new System.EventHandler(this.comboBoxExame_SelectedIndexChanged);
            // 
            // textBoxMedico
            // 
            this.textBoxMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMedico.Location = new System.Drawing.Point(234, 106);
            this.textBoxMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMedico.Name = "textBoxMedico";
            this.textBoxMedico.ReadOnly = true;
            this.textBoxMedico.Size = new System.Drawing.Size(219, 23);
            this.textBoxMedico.TabIndex = 37;
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.dateTimePickerHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerHora.CustomFormat = "HH:mm";
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(234, 63);
            this.dateTimePickerHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerHora.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(46, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "*";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelData.Location = new System.Drawing.Point(10, 45);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(38, 17);
            this.labelData.TabIndex = 39;
            this.labelData.Text = "Data";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHora.Location = new System.Drawing.Point(234, 43);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(39, 17);
            this.labelHora.TabIndex = 41;
            this.labelHora.Text = "Hora";
            // 
            // labelExame
            // 
            this.labelExame.AutoSize = true;
            this.labelExame.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExame.Location = new System.Drawing.Point(10, 88);
            this.labelExame.Name = "labelExame";
            this.labelExame.Size = new System.Drawing.Size(49, 17);
            this.labelExame.TabIndex = 42;
            this.labelExame.Text = "Exame";
            // 
            // labelMedico
            // 
            this.labelMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMedico.AutoSize = true;
            this.labelMedico.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMedico.Location = new System.Drawing.Point(234, 88);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(54, 17);
            this.labelMedico.TabIndex = 43;
            this.labelMedico.Text = "Médico";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPaciente.Location = new System.Drawing.Point(10, 136);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(60, 17);
            this.labelPaciente.TabIndex = 44;
            this.labelPaciente.Text = "Paciente";
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnidade.Location = new System.Drawing.Point(9, 182);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(60, 17);
            this.labelUnidade.TabIndex = 45;
            this.labelUnidade.Text = "Unidade";
            // 
            // labelPrecoLabel
            // 
            this.labelPrecoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrecoLabel.AutoSize = true;
            this.labelPrecoLabel.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrecoLabel.Location = new System.Drawing.Point(69, 230);
            this.labelPrecoLabel.Name = "labelPrecoLabel";
            this.labelPrecoLabel.Size = new System.Drawing.Size(178, 23);
            this.labelPrecoLabel.TabIndex = 48;
            this.labelPrecoLabel.Text = "Preço agendamento:";
            // 
            // labelPreco
            // 
            this.labelPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPreco.Location = new System.Drawing.Point(260, 230);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(84, 27);
            this.labelPreco.TabIndex = 49;
            this.labelPreco.Text = "R$ 0,00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(275, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(288, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(74, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(74, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "*";
            // 
            // AgendamentoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(466, 320);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelPrecoLabel);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgendamentoCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Edição agendamentos";
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
        private Label labelPrecoLabel;
        private Label labelPreco;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}