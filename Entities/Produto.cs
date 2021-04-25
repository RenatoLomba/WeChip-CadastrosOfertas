using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Entities
{
    public class Produto : Base
    {
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public IEnumerable<ProdutoOferta> ProdutosOferta { get; set; }
    }
}
