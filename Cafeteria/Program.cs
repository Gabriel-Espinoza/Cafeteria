using Cafeteria.Factories;
using Cafeteria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> ordenes = new List<Cliente>();

            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Carlos";
            cliente1.Orden = new Orden(TipoCafe.Mocaccino, Tamaño.Venti);
            ordenes.Add(cliente1);

            Cliente cliente2 = new Cliente();
            cliente2.Nombre = "Diego";
            cliente2.Orden = new Orden(TipoCafe.Latte, Tamaño.Alto);
            ordenes.Add(cliente2);

            foreach (var cliente in ordenes)
            {
                IServidorCafe barista = CafeFactory.Instanciar(cliente.Orden.TipoCafe);
                var orden = barista.Servir(cliente.Orden.Tamaño);
                Console.WriteLine(orden);
            }
            Console.ReadKey();
        }
    }
}
