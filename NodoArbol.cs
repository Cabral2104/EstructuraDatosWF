using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatosWF
{
    public class NodoArbol
    {
        public int Valor { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }

        public NodoArbol(int valor)
        {
            Valor = valor;
            Izquierdo = Derecho = null;
        }
    }
}
