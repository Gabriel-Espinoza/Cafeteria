using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Model
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public Orden Orden { get; set; }
    }
}
