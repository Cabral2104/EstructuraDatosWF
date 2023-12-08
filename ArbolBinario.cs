using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatosWF
{
    public class ArbolBinario
    {
        private NodoArbol raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        // Insertar un valor en el árbol
        public void Insertar(int valor)
        {
            raiz = InsertarRec(raiz, valor);
        }

        private NodoArbol InsertarRec(NodoArbol raiz, int valor)
        {
            if (raiz == null)
            {
                raiz = new NodoArbol(valor);
                return raiz;
            }

            if (valor < raiz.Valor)
            {
                raiz.Izquierdo = InsertarRec(raiz.Izquierdo, valor);
            }
            else if (valor > raiz.Valor)
            {
                raiz.Derecho = InsertarRec(raiz.Derecho, valor);
            }

            return raiz;
        }

        // Eliminar un valor del árbol
        public void Eliminar(int valor)
        {
            raiz = EliminarRec(raiz, valor);
        }

        private NodoArbol EliminarRec(NodoArbol raiz, int valor)
        {
            if (raiz == null)
            {
                return raiz;
            }

            if (valor < raiz.Valor)
            {
                raiz.Izquierdo = EliminarRec(raiz.Izquierdo, valor);
            }
            else if (valor > raiz.Valor)
            {
                raiz.Derecho = EliminarRec(raiz.Derecho, valor);
            }
            else
            {
                if (raiz.Izquierdo == null)
                {
                    return raiz.Derecho;
                }
                else if (raiz.Derecho == null)
                {
                    return raiz.Izquierdo;
                }

                raiz.Valor = MinValor(raiz.Derecho);
                raiz.Derecho = EliminarRec(raiz.Derecho, raiz.Valor);
            }

            return raiz;
        }

        private int MinValor(NodoArbol raiz)
        {
            int minv = raiz.Valor;
            while (raiz.Izquierdo != null)
            {
                minv = raiz.Izquierdo.Valor;
                raiz = raiz.Izquierdo;
            }
            return minv;
        }

        // Realizar recorridos en el árbol
        public List<int> Inorden()
        {
            List<int> resultado = new List<int>();
            InordenRec(raiz, resultado);
            return resultado;
        }

        private void InordenRec(NodoArbol raiz, List<int> resultado)
        {
            if (raiz != null)
            {
                InordenRec(raiz.Izquierdo, resultado);
                resultado.Add(raiz.Valor);
                InordenRec(raiz.Derecho, resultado);
            }
        }

        public List<int> Preorden()
        {
            List<int> resultado = new List<int>();
            PreordenRec(raiz, resultado);
            return resultado;
        }

        private void PreordenRec(NodoArbol raiz, List<int> resultado)
        {
            if (raiz != null)
            {
                resultado.Add(raiz.Valor);
                PreordenRec(raiz.Izquierdo, resultado);
                PreordenRec(raiz.Derecho, resultado);
            }
        }

        public List<int> Postorden()
        {
            List<int> resultado = new List<int>();
            PostordenRec(raiz, resultado);
            return resultado;
        }

        private void PostordenRec(NodoArbol raiz, List<int> resultado)
        {
            if (raiz != null)
            {
                PostordenRec(raiz.Izquierdo, resultado);
                PostordenRec(raiz.Derecho, resultado);
                resultado.Add(raiz.Valor);
            }
        }
        public NodoArbol ObtenerNodoRaiz()
        {
            return raiz;
        }
    }
}
