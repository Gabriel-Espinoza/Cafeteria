using Cafeteria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.LN
{
    public class BaristaAmericano : IServidorCafe
    {
        public Cafe Servir(Tamaño tamaño)
        {
            return new Cafe(TipoCafe.Americano, tamaño);
        }
    }

    public class BaristaLatte : IServidorCafe
    {
        public Cafe Servir(Tamaño tamaño)
        {
            return new Cafe(TipoCafe.Latte, tamaño);
        }
    }

    public class BaristaEspresso : IServidorCafe
    {
        public Cafe Servir(Tamaño tamaño)
        {
            return new Cafe(TipoCafe.Espresso, tamaño);
        }
    }

    public class BaristaMocaccino : IServidorCafe
    {
        public Cafe Servir(Tamaño tamaño)
        {
            return new Cafe(TipoCafe.Mocaccino, tamaño);
        }
    }
}
