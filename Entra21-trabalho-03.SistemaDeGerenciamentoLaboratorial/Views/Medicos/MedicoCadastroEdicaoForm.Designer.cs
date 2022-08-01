namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Medicos
{
    partial class MedicoCadastroEdicaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicoCadastroEdicaoForm));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelUf = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxUf = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelCrm = new System.Windows.Forms.Label();
            this.textBoxCrm = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(8, 66);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(390, 23);
            this.textBoxNome.TabIndex = 49;
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
            this.buttonCancelar.Location = new System.Drawing.Point(226, 258);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonCancelar.Size = new System.Drawing.Size(172, 46);
            this.buttonCancelar.TabIndex = 48;
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
            this.buttonSalvar.Location = new System.Drawing.Point(5, 258);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(170, 46);
            this.buttonSalvar.TabIndex = 47;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUf.Location = new System.Drawing.Point(150, 150);
            this.labelUf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(26, 17);
            this.labelUf.TabIndex = 40;
            this.labelUf.Text = "UF";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(8, 202);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(43, 17);
            this.labelEmail.TabIndex = 39;
            this.labelEmail.Text = "Email";
            // 
            // labelTelefone
            // 
            this.labelTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefone.Location = new System.Drawing.Point(266, 149);
            this.labelTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(61, 17);
            this.labelTelefone.TabIndex = 38;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelCpf
            // 
            this.labelCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCpf.Location = new System.Drawing.Point(249, 95);
            this.labelCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(33, 17);
            this.labelCpf.TabIndex = 37;
            this.labelCpf.Text = "CPF";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataNascimento.Location = new System.Drawing.Point(5, 96);
            this.labelDataNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(115, 17);
            this.labelDataNascimento.TabIndex = 36;
            this.labelDataNascimento.Text = "Data Nascimento";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.labelTitulo.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.labelTitulo.Location = new System.Drawing.Point(91, 9);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(233, 27);
            this.labelTitulo.TabIndex = 35;
            this.labelTitulo.Text = "CADASTRO/EDIÇÃO:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(8, 48);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 17);
            this.labelNome.TabIndex = 34;
            this.labelNome.Text = "Nome";
            // 
            // textBoxUf
            // 
            this.textBoxUf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUf.Location = new System.Drawing.Point(148, 169);
            this.textBoxUf.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUf.Name = "textBoxUf";
            this.textBoxUf.Size = new System.Drawing.Size(88, 23);
            this.textBoxUf.TabIndex = 33;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(11, 221);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(388, 23);
            this.textBoxEmail.TabIndex = 31;
            // 
            // labelCrm
            // 
            this.labelCrm.AutoSize = true;
            this.labelCrm.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCrm.Location = new System.Drawing.Point(11, 148);
            this.labelCrm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCrm.Name = "labelCrm";
            this.labelCrm.Size = new System.Drawing.Size(39, 17);
            this.labelCrm.TabIndex = 51;
            this.labelCrm.Text = "CRM";
            // 
            // textBoxCrm
            // 
            this.textBoxCrm.Location = new System.Drawing.Point(11, 169);
            this.textBoxCrm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCrm.Name = "textBoxCrm";
            this.textBoxCrm.Size = new System.Drawing.Size(113, 23);
            this.textBoxCrm.TabIndex = 50;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(250, 115);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(148, 23);
            this.maskedTextBoxCpf.TabIndex = 53;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(263, 169);
            this.maskedTextBoxTelefone.Mask = "(00)00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBoxTelefone.TabIndex = 54;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(8, 115);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDataNascimento.TabIndex = 55;
            // 
            // MedicoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 315);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.labelCrm);
            this.Controls.Add(this.textBoxCrm);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelUf);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxUf);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "MedicoCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicoCadastroEdicaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label labelUf;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelCpf;
        private Label labelDataNascimento;
        private Label labelTitulo;
        private Label labelNome;
        private TextBox textBoxUf;
        private TextBox textBoxEmail;
        private Label labelCrm;
        private TextBox textBoxCrm;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxTelefone;
        private DateTimePicker dateTimePickerDataNascimento;
    }
}