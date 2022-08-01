namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Pacientes
{
    partial class PacienteListagemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacienteListagemForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNomeFiltrar = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnDataNascimento,
            this.ColumnCpf,
            this.ColumnTelefone,
            this.ColumnEmail});
            this.dataGridView1.Location = new System.Drawing.Point(49, 187);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(912, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 125;
            // 
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.HeaderText = "DataNascimento";
            this.ColumnDataNascimento.MinimumWidth = 6;
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            this.ColumnDataNascimento.ReadOnly = true;
            this.ColumnDataNascimento.Width = 125;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.MinimumWidth = 6;
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            this.ColumnCpf.Width = 125;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.MinimumWidth = 6;
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            this.ColumnTelefone.Width = 125;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 125;
            // 
            // textBoxNomeFiltrar
            // 
            this.textBoxNomeFiltrar.Location = new System.Drawing.Point(145, 69);
            this.textBoxNomeFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNomeFiltrar.Name = "textBoxNomeFiltrar";
            this.textBoxNomeFiltrar.Size = new System.Drawing.Size(325, 27);
            this.textBoxNomeFiltrar.TabIndex = 5;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApagar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.ForeColor = System.Drawing.Color.White;
            this.buttonApagar.Image = ((System.Drawing.Image)(resources.GetObject("buttonApagar.Image")));
            this.buttonApagar.Location = new System.Drawing.Point(877, 15);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(113, 136);
            this.buttonApagar.TabIndex = 19;
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click_1);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.Location = new System.Drawing.Point(759, 15);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(113, 136);
            this.buttonEditar.TabIndex = 18;
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click_1);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCadastrar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrar.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadastrar.Image")));
            this.buttonCadastrar.Location = new System.Drawing.Point(641, 15);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(113, 136);
            this.buttonCadastrar.TabIndex = 17;
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click_1);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(211)))), ((int)(((byte)(75)))));
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.Image")));
            this.buttonPesquisar.Location = new System.Drawing.Point(490, 45);
            this.buttonPesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(97, 81);
            this.buttonPesquisar.TabIndex = 20;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // labelFiltro
            // 
            this.labelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.labelFiltro.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.labelFiltro.Location = new System.Drawing.Point(27, 64);
            this.labelFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(123, 35);
            this.labelFiltro.TabIndex = 21;
            this.labelFiltro.Text = "FILTRO:";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(145, 45);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(59, 21);
            this.labelNome.TabIndex = 22;
            this.labelNome.Text = "Nome:";
            // 
            // PacienteListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 671);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxNomeFiltrar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PacienteListagemForm";
            this.Text = "PacienteListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnDataNascimento;
        private DataGridViewTextBoxColumn ColumnCpf;
        private DataGridViewTextBoxColumn ColumnTelefone;
        private DataGridViewTextBoxColumn ColumnEmail;
        private TextBox textBoxNomeFiltrar;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private Button buttonPesquisar;
        private Label labelFiltro;
        private Label labelNome;
    }
}