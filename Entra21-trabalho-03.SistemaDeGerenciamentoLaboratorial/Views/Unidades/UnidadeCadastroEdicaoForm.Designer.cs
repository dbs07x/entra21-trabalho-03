namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Unidades
{
    partial class UnidadeCadastroEdicaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadeCadastroEdicaoForm));
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUf = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelUnidadeFederativa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogradouro.Location = new System.Drawing.Point(12, 141);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(444, 27);
            this.textBoxLogradouro.TabIndex = 2;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(12, 210);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(183, 27);
            this.textBoxBairro.TabIndex = 3;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCidade.Location = new System.Drawing.Point(201, 210);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(183, 27);
            this.textBoxCidade.TabIndex = 4;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCep.Location = new System.Drawing.Point(241, 80);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(215, 27);
            this.maskedTextBoxCep.TabIndex = 5;
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // textBoxUf
            // 
            this.textBoxUf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUf.Location = new System.Drawing.Point(390, 210);
            this.textBoxUf.Name = "textBoxUf";
            this.textBoxUf.Size = new System.Drawing.Size(66, 27);
            this.textBoxUf.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(12, 57);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 21);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.label7.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(90, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "CADASTRO/EDIÇÃO:";
            // 
            // labelCep
            // 
            this.labelCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCep.AutoSize = true;
            this.labelCep.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCep.Location = new System.Drawing.Point(241, 57);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(41, 21);
            this.labelCep.TabIndex = 15;
            this.labelCep.Text = "CEP";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogradouro.Location = new System.Drawing.Point(12, 117);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(97, 21);
            this.labelLogradouro.TabIndex = 16;
            this.labelLogradouro.Text = "Logradouro";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBairro.Location = new System.Drawing.Point(12, 186);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(56, 21);
            this.labelBairro.TabIndex = 17;
            this.labelBairro.Text = "Bairro";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCidade.Location = new System.Drawing.Point(201, 186);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(62, 21);
            this.labelCidade.TabIndex = 18;
            this.labelCidade.Text = "Cidade";
            // 
            // labelUnidadeFederativa
            // 
            this.labelUnidadeFederativa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnidadeFederativa.AutoSize = true;
            this.labelUnidadeFederativa.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnidadeFederativa.Location = new System.Drawing.Point(390, 186);
            this.labelUnidadeFederativa.Name = "labelUnidadeFederativa";
            this.labelUnidadeFederativa.Size = new System.Drawing.Size(32, 21);
            this.labelUnidadeFederativa.TabIndex = 19;
            this.labelUnidadeFederativa.Text = "UF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(279, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(105, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(62, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(263, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(418, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "*";
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
            this.buttonSalvar.Location = new System.Drawing.Point(12, 272);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(213, 57);
            this.buttonSalvar.TabIndex = 26;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
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
            this.buttonCancelar.Location = new System.Drawing.Point(245, 272);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonCancelar.Size = new System.Drawing.Size(215, 57);
            this.buttonCancelar.TabIndex = 27;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(12, 80);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(215, 27);
            this.textBoxNome.TabIndex = 28;
            // 
            // UnidadeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(472, 341);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUnidadeFederativa);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxUf);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.textBoxLogradouro);
            this.Name = "UnidadeCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Edição Unidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxLogradouro;
        private TextBox textBoxBairro;
        private TextBox textBoxCidade;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox textBoxUf;
        private Label labelNome;
        private Label label7;
        private Label labelCep;
        private Label labelLogradouro;
        private Label labelBairro;
        private Label labelCidade;
        private Label labelUnidadeFederativa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private TextBox textBoxNome;
    }
}