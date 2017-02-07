using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Model
{
    public class Orden
    {
        public Orden() { }
        public Orden(TipoCafe tipoCafe, Tamaño tamaño)
        {
            this.TipoCafe = tipoCafe;
            this.Tamaño = tamaño;
        }

        public TipoCafe TipoCafe { get; set; }
        public Tamaño Tamaño { get; set; }
    }


    public enum TipoCafe {
        Americano,
        Espresso,
        Latte,
        Mocaccino
    }
    public enum Tamaño {
        Alto,
        Grande,
        Venti
    }
}
