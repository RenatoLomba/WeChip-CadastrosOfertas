using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Entities
{
    public class Status : Base
    {
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public bool FinalizaCliente { get; set; }
        public bool ContabilizaVenda { get; set; }
        public IEnumerable<Cliente> Clientes { get; set; }
    }
}
