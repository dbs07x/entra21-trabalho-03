using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models
{
    internal class EnderecoDadosRequisicao
    {
        public bool Erro { get; set; } = false;
        public string Logradouro { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
    }
}
