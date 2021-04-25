using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Models
{
    public class ProdutoOfertaViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public bool IsSelected { get; set; }
    }
}
