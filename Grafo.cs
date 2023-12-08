using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace EstructuraDatosWF
{
    public class Grafo
    {
        private Dictionary<int, List<int>> adyacencias;

        public Grafo()
        {
            adyacencias = new Dictionary<int, List<int>>();
        }

        public void AgregarVertice(int vertice)
        {
            if (!adyacencias.ContainsKey(vertice))
            {
                adyacencias[vertice] = new List<int>();
            }
        }

        public void AgregarArista(int verticeInicio, int verticeFin)
        {
            AgregarVertice(verticeInicio);
            AgregarVertice(verticeFin);

            if (!adyacencias[verticeInicio].Contains(verticeFin))
            {
                adyacencias[verticeInicio].Add(verticeFin);
            }

            if (!adyacencias[verticeFin].Contains(verticeInicio))
            {
                adyacencias[verticeFin].Add(verticeInicio);
            }
        }

        public List<int> ObtenerVertices()
        {
            return new List<int>(adyacencias.Keys);
        }

        public List<int> ObtenerVecinos(int vertice)
        {
            return adyacencias.ContainsKey(vertice) ? adyacencias[vertice] : new List<int>();
        }
        public void EliminarVertice(int vertice)
        {
            if (adyacencias.ContainsKey(vertice))
            {
                adyacencias.Remove(vertice);

                // Eliminar referencias a este vértice en otras listas de adyacencia
                foreach (var listaAdyacente in adyacencias.Values)
                {
                    listaAdyacente.Remove(vertice);
                }
            }
        }

        // Método para eliminar una arista entre dos vértices
        public void EliminarArista(int verticeInicio, int verticeFin)
        {
            if (adyacencias.ContainsKey(verticeInicio) && adyacencias.ContainsKey(verticeFin))
            {
                adyacencias[verticeInicio].Remove(verticeFin);
                adyacencias[verticeFin].Remove(verticeInicio);
            }
        }
    }
}
