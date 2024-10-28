using ConsoleApp10Ciclo2.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10Ciclo2.servicios
{
    internal class ClienteSrv
    {
        // mostrar
        public static void Mostrar(List<Cliente> clientes)
        {
            clientes.ForEach(
                cli => Console.WriteLine($"{cli.Nombre} {cli.Apellido} {cli.Ciudad} {cli.Deuda}")
                );
        }
        // quiero sumar todas las deudas
        public static int Sumar(List<Cliente> clientes)
        {
            var resultado = 0;
            resultado = clientes.Sum(cli => cli.Deuda);
            return resultado;
        }
        // mostrar los clientes ordenados por nombre y apellido
        public static List<Cliente> OrdenarPorNombre(List<Cliente> clientes)
        {
            var resultado = new List<Cliente>();
            resultado = clientes                
                .OrderBy(cli => cli.Apellido)
                .OrderBy(cli => cli.Nombre)
                .ToList();
            return resultado;
        }
        // mostrar los clientes de santiago
        // mostrar los clientes de arica
        public static List<Cliente> Filtrar(List<Cliente> clientes,string ciudad)
        {
            var resultado = new List<Cliente>();
            resultado = clientes.Where(cli => cli.Ciudad == ciudad).ToList();
            return resultado;
        }
        // mostrar los clientes que no tienen deuda
        public static List<Cliente> FiltrarSinDeuda(List<Cliente> clientes)
        {
            var resultado = new List<Cliente>();
            resultado = clientes.Where(cli=>cli.Deuda==0).ToList();
            return resultado;
        }
        public static int SumarClientesSantiago(List<Cliente> clientes)
        {
            var resultado = 0;
            resultado = clientes.Where(cli => cli.Ciudad == "Santiago").Sum(cli => cli.Deuda);
            return resultado;
        }

    }
}
