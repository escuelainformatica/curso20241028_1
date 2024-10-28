using ConsoleApp10Ciclo2.modelos;
using ConsoleApp10Ciclo2.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10Ciclo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var compras = new List<Compra> { 
                new Compra("cocacola", 10, 5),
                new Compra("fanta", 20, 3),
                new Compra("sprite", 10, 2)
            };
            CompraSrv.Mostrar(compras);
            CompraSrv.MostrarLinq(compras);

            Console.WriteLine("La suma es :" + CompraSrv.SumarCantidad(compras));
            Console.WriteLine("El subtotal es :" + CompraSrv.SumarTotales(compras));

            Console.WriteLine("---clientes---");
            var clientes = new List<Cliente>
            {
                new Cliente("John","Doe","Santiago",5000),
                new Cliente("Anna","Zoe","Santiago",200),
                new Cliente("Anna","Smith","Santiago",000),
                new Cliente("Anna","Doe","Santiago",200),
                new Cliente("Bob","S","Santiago",2000),
                new Cliente("Peter","R","Arica",1000),
                new Cliente("Susan","Lambert","Arica",0000),
            };

            ClienteSrv.Mostrar(clientes);
            
            Console.WriteLine("La suma es :"+ClienteSrv.Sumar(clientes));
            Console.WriteLine("Ordenado:");
            ClienteSrv.Mostrar(ClienteSrv.OrdenarPorNombre(clientes));
            Console.WriteLine("Filtrado Santiago:");
            ClienteSrv.Mostrar(ClienteSrv.Filtrar(clientes,"Santiago"));
            Console.WriteLine("Filtrado Arica:");
            ClienteSrv.Mostrar(ClienteSrv.Filtrar(clientes, "Arica"));
            Console.WriteLine("Filtrado Sin Deuda:");
            ClienteSrv.Mostrar(ClienteSrv.FiltrarSinDeuda(clientes));
            Console.WriteLine("Sumar Clientes Santiago:");
            Console.WriteLine(ClienteSrv.SumarClientesSantiago(clientes));
        }
    }
}
