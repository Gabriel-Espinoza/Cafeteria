using Cafeteria.LN;
using Cafeteria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Factories
{
    public static class CafeFactory
    {
        public static IServidorCafe Instanciar(TipoCafe tipoCafe)
        {
            switch (tipoCafe)
            {
                case TipoCafe.Americano:
                    return new BaristaAmericano();
                case TipoCafe.Espresso:
                    return new BaristaEspresso();
                case TipoCafe.Latte:
                    return new BaristaLatte();
                case TipoCafe.Mocaccino:
                    return new BaristaMocaccino();
                default:
                    throw new ArgumentException("No existe un blah para esta wea", "tipoCafe");
            }
        }

    }
}
