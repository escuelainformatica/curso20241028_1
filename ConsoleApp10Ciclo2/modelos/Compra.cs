using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10Ciclo2.modelos
{
    internal class Compra
    {
        public string Producto { set; get; }
        public int Cantidad { set; get; }
        public int PrecioUnitario { set; get; }

        public Compra(string producto, int cantidad, int precioUnitario)
        {
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

        public Compra()
        {
        }
    }
}
