using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10Ciclo2.modelos
{
    internal class Cliente
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Ciudad { set; get; }
        public int Deuda { set; get; }

        public Cliente(string nombre, string apellido, string ciudad, int deuda)
        {
            Nombre = nombre;
            Apellido = apellido;
            Ciudad = ciudad;
            Deuda = deuda;
        }

        public Cliente()
        {
        }
    }
}
