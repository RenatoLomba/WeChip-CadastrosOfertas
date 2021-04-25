using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Entities
{
    public class Oferta: Base
    {
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Guid EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public IEnumerable<ProdutoOferta> ProdutosOferta { get; set; }
    }
}
