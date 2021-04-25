using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Models
{
    public class StatusViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public bool FinalizaCliente { get; set; }
        public bool ContabilizaVenda { get; set; }
    }
}
