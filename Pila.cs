using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatosWF
{
    public class Pila
    {
        private Stack<int> elementos = new Stack<int>();

        // Agrega un elemento a la pila
        public void Apilar(int dato)
        {
            elementos.Push(dato);
        }

        // Elimina y retorna el elemento en la cima de la pila
        public int Desapilar()
        {
            if (elementos.Count > 0)
            {
                return elementos.Pop();
            }
            else
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
        }

        // Retorna el elemento en la cima de la pila sin eliminarlo
        public int Peek()
        {
            if (elementos.Count > 0)
            {
                return elementos.Peek();
            }
            else
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
        }

        // Verifica si la pila está vacía
        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        // Retorna la cantidad de elementos en la pila
        public int Contar()
        {
            return elementos.Count;
        }

        // Limpia todos los elementos de la pila
        public void Limpiar()
        {
            elementos.Clear();
        }

        // Retorna una copia superficial de la pila actual
        public Pila Clonar()
        {
            Pila nuevaPila = new Pila();
            nuevaPila.elementos = new Stack<int>(elementos);
            return nuevaPila;
        }
        public Stack<int> ObtenerElementos()
        {
            return elementos;
        }

    }
}
