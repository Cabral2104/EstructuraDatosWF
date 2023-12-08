using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatosWF
{
    public partial class Form1 : Form
    {
        private Lista lista = new Lista();
        private Pila pila = new Pila();
        private Cola cola = new Cola();
        private ArbolBinario arbol = new ArbolBinario();
        private Grafo grafo = new Grafo();
        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarLista()
        {
            lstResultado.Items.Clear();
            foreach (var elemento in lista.ObtenerElementos())
            {
                lstResultado.Items.Add(elemento);
            }
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                lista.Insertar(dato);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                lista.Eliminar(dato);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lista.Ordenar();
            ActualizarLista();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lista.Limpiar();
            ActualizarLista();
        }

        //PILAS
       
        private void btnApilar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtDatoPila.Text, out int dato))
            {
                pila.Apilar(dato);
                ActualizarPila();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnDesapilar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int elementoDesapilado = pila.Desapilar();
                MessageBox.Show($"Elemento desapilado: {elementoDesapilado}");
                ActualizarPila();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPeek_Click_1(object sender, EventArgs e)
        {
            try
            {
                int elementoEnCima = pila.Peek();
                MessageBox.Show($"Elemento en la cima: {elementoEnCima}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEstaVacia_Click_1(object sender, EventArgs e)
        {
            bool estaVacia = pila.EstaVacia();
            MessageBox.Show($"La pila está vacía: {estaVacia}");
        }

        private void btnContarPila_Click_1(object sender, EventArgs e)
        {
            int cantidadElementos = pila.Contar();
            MessageBox.Show($"Cantidad de elementos en la pila: {cantidadElementos}");
        }

        private void btnLimpiarPila_Click_1(object sender, EventArgs e)
        {
            pila.Limpiar();
            ActualizarPila();
        }

        private void btnClonarPila_Click_1(object sender, EventArgs e)
        {
            Pila nuevaPila = pila.Clonar();
            ActualizarPila(nuevaPila);
        }
        private void ActualizarPila()
        {
            lstResultadoPila.Items.Clear();
            foreach (var elemento in pila.ObtenerElementos())
            {
                lstResultadoPila.Items.Add(elemento.ToString());
            }
        }

        private void ActualizarPila(Pila pila)
        {
            lstResultadoPila.Items.Clear();
            foreach (var elemento in pila.ObtenerElementos())
            {
                lstResultadoPila.Items.Add(elemento.ToString());
            }
        }

        //COLAS

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDatoCola.Text, out int dato))
            {
                cola.Encolar(dato);
                ActualizarCola();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            try
            {
                int elementoDesencolado = cola.Desencolar();
                MessageBox.Show($"Elemento desencolado: {elementoDesencolado}");
                ActualizarCola();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPeekCola_Click_1(object sender, EventArgs e)
        {
            try
            {
                int elementoEnFrente = cola.Peek();
                MessageBox.Show($"Elemento en el frente: {elementoEnFrente}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEstaVaciaCola_Click_1(object sender, EventArgs e)
        {
            bool estaVacia = cola.EstaVacia();
            MessageBox.Show($"La cola está vacía: {estaVacia}");
        }

        private void btnContarCola_Click_1(object sender, EventArgs e)
        {
            int cantidadElementos = cola.Contar();
            MessageBox.Show($"Cantidad de elementos en la cola: {cantidadElementos}");
        }

        private void btnLimpiarCola_Click_1(object sender, EventArgs e)
        {
            cola.Limpiar();
            ActualizarCola();
        }

        private void btnOrdenarCola_Click_1(object sender, EventArgs e)
        {
            Cola colaOrdenada = cola.Ordenar();
            ActualizarCola(colaOrdenada);
        }
        private void ActualizarCola()
        {
            lstResultadoCola.Items.Clear();
            foreach (var elemento in cola.ObtenerElementosComoArreglo())
            {
                lstResultadoCola.Items.Add(elemento.ToString());
            }
        }

        private void ActualizarCola(Cola cola)
        {
            lstResultadoCola.Items.Clear();
            foreach (var elemento in cola.ObtenerElementosComoArreglo())
            { 
                lstResultadoCola.Items.Add(elemento.ToString());
            }
        }

        //ARBOLES

        private void bnInsertarArbol_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorArbol.Text, out int valor))
            {
                arbol.Insertar(valor);
                ActualizarArbol();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnEliminarArbol_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorArbol.Text, out int valor))
            {
                arbol.Eliminar(valor);
                ActualizarArbol();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnInorden_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(", ", arbol.Inorden()));
        }

        private void btnPreorden_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(", ", arbol.Preorden()));
        }

        private void btnPostorden_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(", ", arbol.Postorden()));
        }
        private void ActualizarArbol()
        {
            // Lógica para representar gráficamente el árbol (puedes usar un control TreeView)
            treeViewArbol.Nodes.Clear();
            DibujarArbol(treeViewArbol.Nodes, arbol.ObtenerNodoRaiz());
        }

        private void DibujarArbol(TreeNodeCollection nodos, NodoArbol nodo)
        {
            if (nodo != null)
            {
                TreeNode nuevoNodo = nodos.Add(nodo.Valor.ToString());

                DibujarArbol(nuevoNodo.Nodes, nodo.Izquierdo);
                DibujarArbol(nuevoNodo.Nodes, nodo.Derecho);
            }
        }

        //GRAFO

        private void btnAgregarVertice_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtVertice.Text, out int vertice))
            {
                grafo.AgregarVertice(vertice);
                ActualizarGrafo();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnAgregarArista_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtInicioArista.Text, out int inicio) && int.TryParse(txtFinArista.Text, out int fin))
            {
                grafo.AgregarArista(inicio, fin);
                ActualizarGrafo();
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para el inicio y el fin de la arista.");
            }
        }

        private void btnEliminarVertice_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtVerticeEliminar.Text, out int verticeEliminar))
            {
                grafo.EliminarVertice(verticeEliminar);
                ActualizarGrafo();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnEliminarArista_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtInicioEliminarArista.Text, out int inicioEliminar) && int.TryParse(txtFinEliminarArista.Text, out int finEliminar))
            {
                grafo.EliminarArista(inicioEliminar, finEliminar);
                ActualizarGrafo();
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para el inicio y el fin de la arista.");
            }
        }
        private void ActualizarGrafo()
        {
            // Lógica para representar gráficamente el grafo
            DibujarGrafo();
        }

        private void DibujarGrafo()
        {
            // Lógica para dibujar el grafo en el PictureBox
            Bitmap bitmap = new Bitmap(pictureBoxGrafo.Width, pictureBoxGrafo.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Dibujar vértices
                foreach (var vertice in grafo.ObtenerVertices())
                {
                    var posicion = ObtenerPosicion(vertice);
                    var rectangulo = new RectangleF(posicion.X - 15, posicion.Y - 15, 30, 30); // Ajusta el tamaño del vértice según sea necesario
                    g.FillEllipse(Brushes.Blue, rectangulo);
                    g.DrawString(vertice.ToString(), Font, Brushes.White, posicion);
                }

                // Dibujar aristas
                foreach (var vertice in grafo.ObtenerVertices())
                {
                    foreach (var vecino in grafo.ObtenerVecinos(vertice))
                    {
                        var puntoInicio = ObtenerPosicion(vertice);
                        var puntoFin = ObtenerPosicion(vecino);
                        g.DrawLine(Pens.Black, puntoInicio, puntoFin);
                    }
                }
            }

            pictureBoxGrafo.Image = bitmap;
        }

        private Point ObtenerPosicion(int vertice)
        {
            // Puedes ajustar esto según tus necesidades para distribuir los vértices en el PictureBox
            return new Point(50 + vertice * 50, pictureBoxGrafo.Height / 2);
        }
    }
}
