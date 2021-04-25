using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Models
{
    public class OfertaCompleteViewModel : OfertaViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
