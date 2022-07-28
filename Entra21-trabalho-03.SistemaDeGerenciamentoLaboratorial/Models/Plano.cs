using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models
{
    public class Plano
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Abrangencia { get; set; }
        public string Acomodacao {get; set; }
        public Decimal Coparticipacao { get; set; } 
        public Decimal Preco {get; set; }



    }
}
