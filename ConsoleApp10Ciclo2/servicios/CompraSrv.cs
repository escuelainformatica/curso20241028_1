using ConsoleApp10Ciclo2.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10Ciclo2.servicios
{
    internal class CompraSrv
    {
        public static void Mostrar(List<Compra> compras)
        {
            // for
            // foreach
            // while
            // LINQ
            foreach(var compra in compras)
            {
                Console.WriteLine($"{compra.Producto}\t|{compra.PrecioUnitario}\t|{compra.Cantidad}");
            }
        }
        public static void MostrarLinq(List<Compra> compras)
        {
            // alias => (entonces)  = LAMBDA
            compras.ForEach(compra => Console.WriteLine($"{compra.Producto}\t|{compra.PrecioUnitario}\t|{compra.Cantidad}"));
        }


        public static int SumarCantidad(List<Compra> compras)
        {
            var resultado = 0;
            foreach(var compra in compras)
            {
                resultado= resultado + compra.Cantidad;
            }
            return resultado;
        }
        public static int SumarCantidadLinq(List<Compra> compras)
        {
            var resultado = 0;
            resultado = compras.Sum(compra => compra.Cantidad); // que sume todas las cantidad
            return resultado;
        }
        public static int SumarTotales(List<Compra> compras)
        {
            var resultado = 0;
            foreach (var compra in compras)
            {
                resultado = resultado + (compra.Cantidad*compra.PrecioUnitario);
            }
            return resultado;
        }
        public static int SumarTotalesLinq(List<Compra> compras)
        {
            var resultado = 0;
            resultado = compras.Sum(compra => compra.PrecioUnitario * compra.Cantidad);
            return resultado;
        }

    }
}
