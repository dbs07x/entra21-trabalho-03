using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database;


namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Pacientes
{
    public partial class PacienteCadastroEdicaoForm : Form
    {
        public PacienteCadastroEdicaoForm()
        {
            InitializeComponent();


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PacienteCadastroEdicaoForm
            // 
            this.ClientSize = new System.Drawing.Size(576, 384);
            this.Name = "PacienteCadastroEdicaoForm";
            this.ResumeLayout(false);

        }
    }
}
