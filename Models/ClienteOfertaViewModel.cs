using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Models
{
    public class ClienteOfertaViewModel : ClienteViewModel
    {
        public Guid StatusId { get; set; }
        public StatusViewModel Status { get; set; }
    }
}
