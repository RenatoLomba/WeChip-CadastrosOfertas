using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Entities
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public double Credito { get; set; }
        public Guid StatusId { get; set; }
        public Status Status { get; set; }
        public IEnumerable<Oferta> Ofertas { get; set; }
    }
}
