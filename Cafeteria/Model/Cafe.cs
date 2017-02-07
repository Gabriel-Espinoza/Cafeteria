using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Model
{
    public class Cafe
    {
        public Cafe() { }
        public Cafe(TipoCafe tipoCafe, Tamaño tamaño)
        {
            this.TipoCafe = tipoCafe;
            this.Tamaño = tamaño;
        }

        Tamaño Tamaño { get; set; }
        TipoCafe TipoCafe { get; set; }

        public override string ToString()
        {
            return "Su café es un " + TipoCafe + " de tamaño " + Tamaño;
        }
    }
}
