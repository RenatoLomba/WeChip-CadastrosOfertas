using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip_CadastrosOfertas.Entities
{
    public class Base
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
