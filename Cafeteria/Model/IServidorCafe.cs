using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Model
{
    public interface IServidorCafe
    {
        Cafe Servir(Tamaño tamaño);
    }
}
