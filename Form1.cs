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
    }
}
