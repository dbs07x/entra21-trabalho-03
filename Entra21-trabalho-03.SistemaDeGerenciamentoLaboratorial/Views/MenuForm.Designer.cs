﻿namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanelPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonUnidades = new System.Windows.Forms.Button();
            this.buttonMedicos = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.buttonPlanos = new System.Windows.Forms.Button();
            this.buttonAgendamentos = new System.Windows.Forms.Button();
            this.buttonExames = new System.Windows.Forms.Button();
            this.buttonExames2 = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelPrincipal.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPrincipal
            // 
            this.flowLayoutPanelPrincipal.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanelPrincipal.Controls.Add(this.panelLogo);
            this.flowLayoutPanelPrincipal.Controls.Add(this.buttonDashboard);
            this.flowLayoutPanelPrincipal.Controls.Add(this.buttonUnidades);
            this.flowLayoutPanelPrincipal.Controls.Add(this.buttonMedicos);
            this.flowLayoutPanelPrincipal.Controls.Add(this.buttonPacientes);
            this.flowLayoutPanelPrincipal.Controls.Add(this.buttonPlanos);
            this.flowLayoutPanelPrincipal.Controls.Add(this.buttonAgendamentos);
            this.flowLayoutPanelPrincipal.Controls.Add(this.buttonExames);
            this.flowLayoutPanelPrincipal.Controls.Add(this.buttonExames2);
            this.flowLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelPrincipal.MaximumSize = new System.Drawing.Size(279, 0);
            this.flowLayoutPanelPrincipal.MinimumSize = new System.Drawing.Size(92, 0);
            this.flowLayoutPanelPrincipal.Name = "flowLayoutPanelPrincipal";
            this.flowLayoutPanelPrincipal.Size = new System.Drawing.Size(279, 667);
            this.flowLayoutPanelPrincipal.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Gray;
            this.panelLogo.Controls.Add(this.pictureBoxMenu);
            this.panelLogo.Location = new System.Drawing.Point(3, 2);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(276, 58);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.botao_de_menu_de_tres_linhas_horizontais;
            this.pictureBoxMenu.Location = new System.Drawing.Point(24, 14);
            this.pictureBoxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.pictureBoxMenu.Size = new System.Drawing.Size(48, 33);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 1;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(90)))));
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDashboard.ForeColor = System.Drawing.Color.Black;
            this.buttonDashboard.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.dashboard;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(3, 64);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
<<<<<<< HEAD
            this.buttonDashboard.Size = new System.Drawing.Size(285, 70);
=======
            this.buttonDashboard.Size = new System.Drawing.Size(285, 63);
>>>>>>> Atualizado menu form
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "       Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonUnidades
            // 
            this.buttonUnidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUnidades.FlatAppearance.BorderSize = 0;
            this.buttonUnidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(90)))));
            this.buttonUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnidades.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUnidades.ForeColor = System.Drawing.Color.Black;
            this.buttonUnidades.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.hospital__1_;
            this.buttonUnidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.buttonUnidades.Location = new System.Drawing.Point(3, 138);
            this.buttonUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnidades.Name = "buttonUnidades";
            this.buttonUnidades.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonUnidades.Size = new System.Drawing.Size(285, 70);
=======
            this.buttonUnidades.Location = new System.Drawing.Point(3, 131);
            this.buttonUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnidades.Name = "buttonUnidades";
            this.buttonUnidades.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonUnidades.Size = new System.Drawing.Size(285, 63);
>>>>>>> Atualizado menu form
            this.buttonUnidades.TabIndex = 1;
            this.buttonUnidades.Text = "       Unidades";
            this.buttonUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUnidades.UseVisualStyleBackColor = true;
            this.buttonUnidades.Click += new System.EventHandler(this.buttonUnidades_Click);
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMedicos.FlatAppearance.BorderSize = 0;
            this.buttonMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(90)))));
            this.buttonMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedicos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMedicos.ForeColor = System.Drawing.Color.Black;
            this.buttonMedicos.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.medico;
            this.buttonMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.buttonMedicos.Location = new System.Drawing.Point(3, 212);
            this.buttonMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonMedicos.Size = new System.Drawing.Size(285, 70);
=======
            this.buttonMedicos.Location = new System.Drawing.Point(3, 198);
            this.buttonMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonMedicos.Size = new System.Drawing.Size(285, 58);
>>>>>>> Atualizado menu form
            this.buttonMedicos.TabIndex = 2;
            this.buttonMedicos.Text = "       Médicos";
            this.buttonMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMedicos.UseVisualStyleBackColor = true;
            this.buttonMedicos.Click += new System.EventHandler(this.buttonMedicos_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPacientes.FlatAppearance.BorderSize = 0;
            this.buttonPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(90)))));
            this.buttonPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPacientes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPacientes.ForeColor = System.Drawing.Color.Black;
            this.buttonPacientes.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.sneezing;
            this.buttonPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.buttonPacientes.Location = new System.Drawing.Point(3, 286);
            this.buttonPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonPacientes.Size = new System.Drawing.Size(285, 70);
=======
            this.buttonPacientes.Location = new System.Drawing.Point(3, 260);
            this.buttonPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonPacientes.Size = new System.Drawing.Size(285, 63);
>>>>>>> Atualizado menu form
            this.buttonPacientes.TabIndex = 3;
            this.buttonPacientes.Text = "       Pacientes";
            this.buttonPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPacientes.UseVisualStyleBackColor = true;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // buttonPlanos
            // 
            this.buttonPlanos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlanos.FlatAppearance.BorderSize = 0;
            this.buttonPlanos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(90)))));
            this.buttonPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlanos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlanos.ForeColor = System.Drawing.Color.Black;
            this.buttonPlanos.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.prancheta;
            this.buttonPlanos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.buttonPlanos.Location = new System.Drawing.Point(3, 360);
            this.buttonPlanos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlanos.Name = "buttonPlanos";
            this.buttonPlanos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonPlanos.Size = new System.Drawing.Size(285, 70);
=======
            this.buttonPlanos.Location = new System.Drawing.Point(3, 327);
            this.buttonPlanos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlanos.Name = "buttonPlanos";
            this.buttonPlanos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonPlanos.Size = new System.Drawing.Size(285, 63);
>>>>>>> Atualizado menu form
            this.buttonPlanos.TabIndex = 4;
            this.buttonPlanos.Text = "       Planos";
            this.buttonPlanos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlanos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPlanos.UseVisualStyleBackColor = true;
            this.buttonPlanos.Click += new System.EventHandler(this.buttonPlanos_Click);
            // 
            // buttonAgendamentos
            // 
            this.buttonAgendamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAgendamentos.FlatAppearance.BorderSize = 0;
            this.buttonAgendamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(90)))));
            this.buttonAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgendamentos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgendamentos.ForeColor = System.Drawing.Color.Black;
            this.buttonAgendamentos.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.calendario;
            this.buttonAgendamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.buttonAgendamentos.Location = new System.Drawing.Point(3, 434);
            this.buttonAgendamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgendamentos.Name = "buttonAgendamentos";
            this.buttonAgendamentos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonAgendamentos.Size = new System.Drawing.Size(285, 70);
=======
            this.buttonAgendamentos.Location = new System.Drawing.Point(3, 394);
            this.buttonAgendamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgendamentos.Name = "buttonAgendamentos";
            this.buttonAgendamentos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonAgendamentos.Size = new System.Drawing.Size(285, 63);
>>>>>>> Atualizado menu form
            this.buttonAgendamentos.TabIndex = 5;
            this.buttonAgendamentos.Text = "       Agendamentos";
            this.buttonAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgendamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAgendamentos.UseVisualStyleBackColor = true;
            this.buttonAgendamentos.Click += new System.EventHandler(this.buttonAgendamentos_Click);
            // 
            // buttonExames
            // 
            this.buttonExames.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExames.FlatAppearance.BorderSize = 0;
            this.buttonExames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(90)))));
            this.buttonExames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExames.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExames.ForeColor = System.Drawing.Color.Black;
            this.buttonExames.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.prancheta;
            this.buttonExames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.buttonExames.Location = new System.Drawing.Point(3, 508);
=======
            this.buttonExames.Location = new System.Drawing.Point(3, 461);
>>>>>>> Atualizado menu form
            this.buttonExames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExames.MaximumSize = new System.Drawing.Size(285, 63);
            this.buttonExames.Name = "buttonExames";
            this.buttonExames.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonExames.Size = new System.Drawing.Size(285, 0);
            this.buttonExames.TabIndex = 6;
            this.buttonExames.Text = "       Exames";
            this.buttonExames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExames.UseVisualStyleBackColor = true;
            // 
            // buttonExames2
            // 
            this.buttonExames2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExames2.FlatAppearance.BorderSize = 0;
            this.buttonExames2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(90)))));
            this.buttonExames2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExames2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExames2.ForeColor = System.Drawing.Color.Black;
            this.buttonExames2.Image = global::Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Properties.Resources.teste_de_sangue;
            this.buttonExames2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.buttonExames2.Location = new System.Drawing.Point(3, 512);
            this.buttonExames2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExames2.Name = "buttonExames2";
            this.buttonExames2.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonExames2.Size = new System.Drawing.Size(285, 70);
=======
            this.buttonExames2.Location = new System.Drawing.Point(3, 465);
            this.buttonExames2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExames2.Name = "buttonExames2";
            this.buttonExames2.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonExames2.Size = new System.Drawing.Size(285, 63);
>>>>>>> Atualizado menu form
            this.buttonExames2.TabIndex = 7;
            this.buttonExames2.Text = "       Exames";
            this.buttonExames2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExames2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExames2.UseVisualStyleBackColor = true;
            this.buttonExames2.Click += new System.EventHandler(this.buttonExames2_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(279, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1214, 667);
            this.panelForm.TabIndex = 1;
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 5;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 667);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.flowLayoutPanelPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "Sistema de gerenciamento laboratorial";
            this.flowLayoutPanelPrincipal.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelPrincipal;
        private Panel panelLogo;
        private Button buttonDashboard;
        private Button buttonUnidades;
        private Button buttonMedicos;
        private Button buttonPacientes;
        private Button buttonPlanos;
        private Button buttonAgendamentos;
        private Button buttonExames;
        private Panel panelForm;
        private PictureBox pictureBoxMenu;
        private System.Windows.Forms.Timer timerSidebar;
        private Button buttonExames2;
    }
}