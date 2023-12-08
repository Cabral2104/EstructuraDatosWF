using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatosWF
{
    public class Cola
    {
        private Queue<int> elementos = new Queue<int>();

        // Agrega un elemento al final de la cola
        public void Encolar(int dato)
        {
            elementos.Enqueue(dato);
        }

        // Elimina y retorna el elemento al principio de la cola
        public int Desencolar()
        {
            if (elementos.Count > 0)
            {
                return elementos.Dequeue();
            }
            else
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
        }

        // Retorna el elemento al principio de la cola sin eliminarlo
        public int Peek()
        {
            if (elementos.Count > 0)
            {
                return elementos.Peek();
            }
            else
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
        }

        // Verifica si la cola está vacía
        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        // Retorna la cantidad de elementos en la cola
        public int Contar()
        {
            return elementos.Count;
        }

        // Limpia todos los elementos de la cola
        public void Limpiar()
        {
            elementos.Clear();
        }

        // Retorna una copia superficial de la cola actual
        public Cola Clonar()
        {
            Cola nuevaCola = new Cola();
            nuevaCola.elementos = new Queue<int>(elementos);
            return nuevaCola;
        }

        // Nuevo método para obtener una nueva cola con elementos ordenados
        public Cola Ordenar()
        {
            int[] elementosOrdenados = elementos.OrderBy(x => x).ToArray();

            Cola colaOrdenada = new Cola();
            foreach (var elemento in elementosOrdenados)
            {
                colaOrdenada.Encolar(elemento);
            }

            return colaOrdenada;
        }
        public int[] ObtenerElementosComoArreglo()
        {
            return elementos.ToArray();
        }
    }
}
