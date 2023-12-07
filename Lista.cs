using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatosWF
{
    public class Lista
    {
        private List<int> elementos = new List<int>();

        // Inserta un elemento al final de la lista
        public void Insertar(int dato)
        {
            elementos.Add(dato);
        }

        // Elimina la primera ocurrencia del elemento en la lista
        public void Eliminar(int dato)
        {
            elementos.Remove(dato);
        }

        // Verifica si un elemento está presente en la lista
        public bool Contiene(int dato)
        {
            return elementos.Contains(dato);
        }

        // Retorna el índice de la primera ocurrencia del elemento en la lista
        // Retorna -1 si no se encuentra
        public int Buscar(int dato)
        {
            return elementos.IndexOf(dato);
        }

        // Retorna la cantidad de elementos en la lista
        public int Contar()
        {
            return elementos.Count;
        }

        // Retorna una copia de la lista
        public List<int> ObtenerElementos()
        {
            return new List<int>(elementos);
        }

        // Ordena los elementos de la lista
        public void Ordenar()
        {
            elementos.Sort();
        }

        // Elimina todos los elementos de la lista
        public void Limpiar()
        {
            elementos.Clear();
        }

        // Realiza una copia superficial de la lista actual
        public Lista Clonar()
        {
            Lista nuevaLista = new Lista();
            nuevaLista.elementos.AddRange(elementos);
            return nuevaLista;
        }
    }
}
