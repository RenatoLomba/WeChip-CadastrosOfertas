using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Models
{
    public class OfertaViewModel
    {
        public ClienteOfertaViewModel Cliente { get; set; }
        public IEnumerable<ProdutoOfertaViewModel> Produtos { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public IEnumerable<StatusViewModel> StatusList { get; set; }
    }
}
