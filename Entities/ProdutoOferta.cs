using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Entities
{
    public class ProdutoOferta : Base
    {
        public Guid OfertaId { get; set; }
        public Oferta Oferta { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
