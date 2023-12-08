namespace EstructuraDatosWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabListas = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.tabPilas = new System.Windows.Forms.TabPage();
            this.btnClonarPila = new System.Windows.Forms.Button();
            this.lstResultadoPila = new System.Windows.Forms.ListView();
            this.btnLimpiarPila = new System.Windows.Forms.Button();
            this.btnContarPila = new System.Windows.Forms.Button();
            this.btnEstaVacia = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.txtDatoPila = new System.Windows.Forms.TextBox();
            this.btnApilar = new System.Windows.Forms.Button();
            this.tabColas = new System.Windows.Forms.TabPage();
            this.txtDatoCola = new System.Windows.Forms.TextBox();
            this.lstResultadoCola = new System.Windows.Forms.ListView();
            this.btnOrdenarCola = new System.Windows.Forms.Button();
            this.btnLimpiarCola = new System.Windows.Forms.Button();
            this.btnContarCola = new System.Windows.Forms.Button();
            this.btnEstaVaciaCola = new System.Windows.Forms.Button();
            this.btnPeekCola = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.tabArboles = new System.Windows.Forms.TabPage();
            this.txtValorArbol = new System.Windows.Forms.TextBox();
            this.btnPostorden = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnInorden = new System.Windows.Forms.Button();
            this.btnEliminarArbol = new System.Windows.Forms.Button();
            this.bnInsertarArbol = new System.Windows.Forms.Button();
            this.treeViewArbol = new System.Windows.Forms.TreeView();
            this.tabGrafos = new System.Windows.Forms.TabPage();
            this.txtVertice = new System.Windows.Forms.TextBox();
            this.btnAgregarVertice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarArista = new System.Windows.Forms.Button();
            this.txtInicioArista = new System.Windows.Forms.TextBox();
            this.txtFinArista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxGrafo = new System.Windows.Forms.PictureBox();
            this.txtVerticeEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarVertice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarArista = new System.Windows.Forms.Button();
            this.txtInicioEliminarArista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFinEliminarArista = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabListas.SuspendLayout();
            this.tabPilas.SuspendLayout();
            this.tabColas.SuspendLayout();
            this.tabArboles.SuspendLayout();
            this.tabGrafos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabListas);
            this.tabControl1.Controls.Add(this.tabPilas);
            this.tabControl1.Controls.Add(this.tabColas);
            this.tabControl1.Controls.Add(this.tabArboles);
            this.tabControl1.Controls.Add(this.tabGrafos);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabListas
            // 
            this.tabListas.AccessibleName = "tabListas";
            this.tabListas.Controls.Add(this.btnLimpiar);
            this.tabListas.Controls.Add(this.btnOrdenar);
            this.tabListas.Controls.Add(this.btnMostrar);
            this.tabListas.Controls.Add(this.btnEliminar);
            this.tabListas.Controls.Add(this.btnInsertar);
            this.tabListas.Controls.Add(this.lstResultado);
            this.tabListas.Controls.Add(this.txtDato);
            this.tabListas.Location = new System.Drawing.Point(4, 22);
            this.tabListas.Name = "tabListas";
            this.tabListas.Padding = new System.Windows.Forms.Padding(3);
            this.tabListas.Size = new System.Drawing.Size(768, 351);
            this.tabListas.TabIndex = 0;
            this.tabListas.Text = "Listas";
            this.tabListas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(544, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 32);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(544, 86);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(118, 32);
            this.btnOrdenar.TabIndex = 5;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(544, 19);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(118, 32);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(354, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(354, 19);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(118, 32);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // lstResultado
            // 
            this.lstResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(193, 143);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(279, 160);
            this.lstResultado.TabIndex = 1;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(109, 47);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(162, 20);
            this.txtDato.TabIndex = 0;
            // 
            // tabPilas
            // 
            this.tabPilas.AccessibleName = "tabPilas";
            this.tabPilas.Controls.Add(this.btnClonarPila);
            this.tabPilas.Controls.Add(this.lstResultadoPila);
            this.tabPilas.Controls.Add(this.btnLimpiarPila);
            this.tabPilas.Controls.Add(this.btnContarPila);
            this.tabPilas.Controls.Add(this.btnEstaVacia);
            this.tabPilas.Controls.Add(this.btnPeek);
            this.tabPilas.Controls.Add(this.btnDesapilar);
            this.tabPilas.Controls.Add(this.txtDatoPila);
            this.tabPilas.Controls.Add(this.btnApilar);
            this.tabPilas.Location = new System.Drawing.Point(4, 22);
            this.tabPilas.Name = "tabPilas";
            this.tabPilas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPilas.Size = new System.Drawing.Size(768, 351);
            this.tabPilas.TabIndex = 1;
            this.tabPilas.Text = "Pilas";
            this.tabPilas.UseVisualStyleBackColor = true;
            // 
            // btnClonarPila
            // 
            this.btnClonarPila.Location = new System.Drawing.Point(537, 251);
            this.btnClonarPila.Name = "btnClonarPila";
            this.btnClonarPila.Size = new System.Drawing.Size(115, 40);
            this.btnClonarPila.TabIndex = 8;
            this.btnClonarPila.Text = "Clonar Pila";
            this.btnClonarPila.UseVisualStyleBackColor = true;
            this.btnClonarPila.Click += new System.EventHandler(this.btnClonarPila_Click_1);
            // 
            // lstResultadoPila
            // 
            this.lstResultadoPila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstResultadoPila.HideSelection = false;
            this.lstResultadoPila.Location = new System.Drawing.Point(109, 144);
            this.lstResultadoPila.Name = "lstResultadoPila";
            this.lstResultadoPila.Size = new System.Drawing.Size(269, 179);
            this.lstResultadoPila.TabIndex = 7;
            this.lstResultadoPila.UseCompatibleStateImageBehavior = false;
            // 
            // btnLimpiarPila
            // 
            this.btnLimpiarPila.Location = new System.Drawing.Point(625, 181);
            this.btnLimpiarPila.Name = "btnLimpiarPila";
            this.btnLimpiarPila.Size = new System.Drawing.Size(115, 40);
            this.btnLimpiarPila.TabIndex = 6;
            this.btnLimpiarPila.Text = "Limpiar Pila";
            this.btnLimpiarPila.UseVisualStyleBackColor = true;
            this.btnLimpiarPila.Click += new System.EventHandler(this.btnLimpiarPila_Click_1);
            // 
            // btnContarPila
            // 
            this.btnContarPila.Location = new System.Drawing.Point(625, 115);
            this.btnContarPila.Name = "btnContarPila";
            this.btnContarPila.Size = new System.Drawing.Size(115, 40);
            this.btnContarPila.TabIndex = 5;
            this.btnContarPila.Text = "Contar Pila";
            this.btnContarPila.UseVisualStyleBackColor = true;
            this.btnContarPila.Click += new System.EventHandler(this.btnContarPila_Click_1);
            // 
            // btnEstaVacia
            // 
            this.btnEstaVacia.Location = new System.Drawing.Point(625, 40);
            this.btnEstaVacia.Name = "btnEstaVacia";
            this.btnEstaVacia.Size = new System.Drawing.Size(115, 40);
            this.btnEstaVacia.TabIndex = 4;
            this.btnEstaVacia.Text = "Esta Vacía";
            this.btnEstaVacia.UseVisualStyleBackColor = true;
            this.btnEstaVacia.Click += new System.EventHandler(this.btnEstaVacia_Click_1);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(473, 181);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(115, 40);
            this.btnPeek.TabIndex = 3;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click_1);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(473, 115);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(115, 40);
            this.btnDesapilar.TabIndex = 2;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click_1);
            // 
            // txtDatoPila
            // 
            this.txtDatoPila.Location = new System.Drawing.Point(170, 76);
            this.txtDatoPila.Name = "txtDatoPila";
            this.txtDatoPila.Size = new System.Drawing.Size(151, 20);
            this.txtDatoPila.TabIndex = 1;
            // 
            // btnApilar
            // 
            this.btnApilar.Location = new System.Drawing.Point(473, 40);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(115, 40);
            this.btnApilar.TabIndex = 0;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click_1);
            // 
            // tabColas
            // 
            this.tabColas.AccessibleName = "tabColas";
            this.tabColas.Controls.Add(this.txtDatoCola);
            this.tabColas.Controls.Add(this.lstResultadoCola);
            this.tabColas.Controls.Add(this.btnOrdenarCola);
            this.tabColas.Controls.Add(this.btnLimpiarCola);
            this.tabColas.Controls.Add(this.btnContarCola);
            this.tabColas.Controls.Add(this.btnEstaVaciaCola);
            this.tabColas.Controls.Add(this.btnPeekCola);
            this.tabColas.Controls.Add(this.btnDesencolar);
            this.tabColas.Controls.Add(this.btnEncolar);
            this.tabColas.Location = new System.Drawing.Point(4, 22);
            this.tabColas.Name = "tabColas";
            this.tabColas.Padding = new System.Windows.Forms.Padding(3);
            this.tabColas.Size = new System.Drawing.Size(768, 351);
            this.tabColas.TabIndex = 2;
            this.tabColas.Text = "Colas";
            this.tabColas.UseVisualStyleBackColor = true;
            // 
            // txtDatoCola
            // 
            this.txtDatoCola.Location = new System.Drawing.Point(168, 61);
            this.txtDatoCola.Name = "txtDatoCola";
            this.txtDatoCola.Size = new System.Drawing.Size(164, 20);
            this.txtDatoCola.TabIndex = 8;
            // 
            // lstResultadoCola
            // 
            this.lstResultadoCola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstResultadoCola.HideSelection = false;
            this.lstResultadoCola.Location = new System.Drawing.Point(60, 127);
            this.lstResultadoCola.Name = "lstResultadoCola";
            this.lstResultadoCola.Size = new System.Drawing.Size(339, 211);
            this.lstResultadoCola.TabIndex = 7;
            this.lstResultadoCola.UseCompatibleStateImageBehavior = false;
            // 
            // btnOrdenarCola
            // 
            this.btnOrdenarCola.Location = new System.Drawing.Point(507, 206);
            this.btnOrdenarCola.Name = "btnOrdenarCola";
            this.btnOrdenarCola.Size = new System.Drawing.Size(108, 42);
            this.btnOrdenarCola.TabIndex = 6;
            this.btnOrdenarCola.Text = "Ordenar Cola";
            this.btnOrdenarCola.UseVisualStyleBackColor = true;
            this.btnOrdenarCola.Click += new System.EventHandler(this.btnOrdenarCola_Click_1);
            // 
            // btnLimpiarCola
            // 
            this.btnLimpiarCola.Location = new System.Drawing.Point(586, 158);
            this.btnLimpiarCola.Name = "btnLimpiarCola";
            this.btnLimpiarCola.Size = new System.Drawing.Size(108, 42);
            this.btnLimpiarCola.TabIndex = 5;
            this.btnLimpiarCola.Text = "Limpiar Cola";
            this.btnLimpiarCola.UseVisualStyleBackColor = true;
            this.btnLimpiarCola.Click += new System.EventHandler(this.btnLimpiarCola_Click_1);
            // 
            // btnContarCola
            // 
            this.btnContarCola.Location = new System.Drawing.Point(586, 99);
            this.btnContarCola.Name = "btnContarCola";
            this.btnContarCola.Size = new System.Drawing.Size(108, 42);
            this.btnContarCola.TabIndex = 4;
            this.btnContarCola.Text = "Contar Cola";
            this.btnContarCola.UseVisualStyleBackColor = true;
            this.btnContarCola.Click += new System.EventHandler(this.btnContarCola_Click_1);
            // 
            // btnEstaVaciaCola
            // 
            this.btnEstaVaciaCola.Location = new System.Drawing.Point(586, 39);
            this.btnEstaVaciaCola.Name = "btnEstaVaciaCola";
            this.btnEstaVaciaCola.Size = new System.Drawing.Size(108, 42);
            this.btnEstaVaciaCola.TabIndex = 3;
            this.btnEstaVaciaCola.Text = "Esta Vacía";
            this.btnEstaVaciaCola.UseVisualStyleBackColor = true;
            this.btnEstaVaciaCola.Click += new System.EventHandler(this.btnEstaVaciaCola_Click_1);
            // 
            // btnPeekCola
            // 
            this.btnPeekCola.Location = new System.Drawing.Point(436, 158);
            this.btnPeekCola.Name = "btnPeekCola";
            this.btnPeekCola.Size = new System.Drawing.Size(108, 42);
            this.btnPeekCola.TabIndex = 2;
            this.btnPeekCola.Text = "Peek";
            this.btnPeekCola.UseVisualStyleBackColor = true;
            this.btnPeekCola.Click += new System.EventHandler(this.btnPeekCola_Click_1);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(436, 99);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(108, 42);
            this.btnDesencolar.TabIndex = 1;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(436, 39);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(108, 42);
            this.btnEncolar.TabIndex = 0;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // tabArboles
            // 
            this.tabArboles.AccessibleName = "tabArboles";
            this.tabArboles.Controls.Add(this.txtValorArbol);
            this.tabArboles.Controls.Add(this.btnPostorden);
            this.tabArboles.Controls.Add(this.btnPreorden);
            this.tabArboles.Controls.Add(this.btnInorden);
            this.tabArboles.Controls.Add(this.btnEliminarArbol);
            this.tabArboles.Controls.Add(this.bnInsertarArbol);
            this.tabArboles.Controls.Add(this.treeViewArbol);
            this.tabArboles.Location = new System.Drawing.Point(4, 22);
            this.tabArboles.Name = "tabArboles";
            this.tabArboles.Padding = new System.Windows.Forms.Padding(3);
            this.tabArboles.Size = new System.Drawing.Size(768, 351);
            this.tabArboles.TabIndex = 3;
            this.tabArboles.Text = "Arboles";
            this.tabArboles.UseVisualStyleBackColor = true;
            // 
            // txtValorArbol
            // 
            this.txtValorArbol.Location = new System.Drawing.Point(156, 46);
            this.txtValorArbol.Name = "txtValorArbol";
            this.txtValorArbol.Size = new System.Drawing.Size(185, 20);
            this.txtValorArbol.TabIndex = 6;
            // 
            // btnPostorden
            // 
            this.btnPostorden.Location = new System.Drawing.Point(532, 178);
            this.btnPostorden.Name = "btnPostorden";
            this.btnPostorden.Size = new System.Drawing.Size(104, 47);
            this.btnPostorden.TabIndex = 5;
            this.btnPostorden.Text = "Postorden";
            this.btnPostorden.UseVisualStyleBackColor = true;
            this.btnPostorden.Click += new System.EventHandler(this.btnPostorden_Click_1);
            // 
            // btnPreorden
            // 
            this.btnPreorden.Location = new System.Drawing.Point(610, 104);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(104, 47);
            this.btnPreorden.TabIndex = 4;
            this.btnPreorden.Text = "Preorden";
            this.btnPreorden.UseVisualStyleBackColor = true;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click_1);
            // 
            // btnInorden
            // 
            this.btnInorden.Location = new System.Drawing.Point(610, 32);
            this.btnInorden.Name = "btnInorden";
            this.btnInorden.Size = new System.Drawing.Size(104, 47);
            this.btnInorden.TabIndex = 3;
            this.btnInorden.Text = "Inorden";
            this.btnInorden.UseVisualStyleBackColor = true;
            this.btnInorden.Click += new System.EventHandler(this.btnInorden_Click_1);
            // 
            // btnEliminarArbol
            // 
            this.btnEliminarArbol.Location = new System.Drawing.Point(463, 104);
            this.btnEliminarArbol.Name = "btnEliminarArbol";
            this.btnEliminarArbol.Size = new System.Drawing.Size(104, 47);
            this.btnEliminarArbol.TabIndex = 2;
            this.btnEliminarArbol.Text = "Eliminar";
            this.btnEliminarArbol.UseVisualStyleBackColor = true;
            this.btnEliminarArbol.Click += new System.EventHandler(this.btnEliminarArbol_Click_1);
            // 
            // bnInsertarArbol
            // 
            this.bnInsertarArbol.Location = new System.Drawing.Point(463, 32);
            this.bnInsertarArbol.Name = "bnInsertarArbol";
            this.bnInsertarArbol.Size = new System.Drawing.Size(104, 47);
            this.bnInsertarArbol.TabIndex = 1;
            this.bnInsertarArbol.Text = "Insetar";
            this.bnInsertarArbol.UseVisualStyleBackColor = true;
            this.bnInsertarArbol.Click += new System.EventHandler(this.bnInsertarArbol_Click);
            // 
            // treeViewArbol
            // 
            this.treeViewArbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeViewArbol.Location = new System.Drawing.Point(47, 104);
            this.treeViewArbol.Name = "treeViewArbol";
            this.treeViewArbol.Size = new System.Drawing.Size(360, 223);
            this.treeViewArbol.TabIndex = 0;
            // 
            // tabGrafos
            // 
            this.tabGrafos.AccessibleName = "tabGrafos";
            this.tabGrafos.Controls.Add(this.txtFinEliminarArista);
            this.tabGrafos.Controls.Add(this.label6);
            this.tabGrafos.Controls.Add(this.label5);
            this.tabGrafos.Controls.Add(this.txtInicioEliminarArista);
            this.tabGrafos.Controls.Add(this.btnEliminarArista);
            this.tabGrafos.Controls.Add(this.label4);
            this.tabGrafos.Controls.Add(this.btnEliminarVertice);
            this.tabGrafos.Controls.Add(this.txtVerticeEliminar);
            this.tabGrafos.Controls.Add(this.pictureBoxGrafo);
            this.tabGrafos.Controls.Add(this.label3);
            this.tabGrafos.Controls.Add(this.label2);
            this.tabGrafos.Controls.Add(this.txtFinArista);
            this.tabGrafos.Controls.Add(this.txtInicioArista);
            this.tabGrafos.Controls.Add(this.btnAgregarArista);
            this.tabGrafos.Controls.Add(this.label1);
            this.tabGrafos.Controls.Add(this.btnAgregarVertice);
            this.tabGrafos.Controls.Add(this.txtVertice);
            this.tabGrafos.Location = new System.Drawing.Point(4, 22);
            this.tabGrafos.Name = "tabGrafos";
            this.tabGrafos.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrafos.Size = new System.Drawing.Size(768, 351);
            this.tabGrafos.TabIndex = 4;
            this.tabGrafos.Text = "Grafos";
            this.tabGrafos.UseVisualStyleBackColor = true;
            // 
            // txtVertice
            // 
            this.txtVertice.Location = new System.Drawing.Point(52, 14);
            this.txtVertice.Name = "txtVertice";
            this.txtVertice.Size = new System.Drawing.Size(147, 20);
            this.txtVertice.TabIndex = 0;
            // 
            // btnAgregarVertice
            // 
            this.btnAgregarVertice.Location = new System.Drawing.Point(271, 6);
            this.btnAgregarVertice.Name = "btnAgregarVertice";
            this.btnAgregarVertice.Size = new System.Drawing.Size(116, 43);
            this.btnAgregarVertice.TabIndex = 1;
            this.btnAgregarVertice.Text = "Agregar Vertice";
            this.btnAgregarVertice.UseVisualStyleBackColor = true;
            this.btnAgregarVertice.Click += new System.EventHandler(this.btnAgregarVertice_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vertice";
            // 
            // btnAgregarArista
            // 
            this.btnAgregarArista.Location = new System.Drawing.Point(271, 55);
            this.btnAgregarArista.Name = "btnAgregarArista";
            this.btnAgregarArista.Size = new System.Drawing.Size(116, 43);
            this.btnAgregarArista.TabIndex = 3;
            this.btnAgregarArista.Text = "Agregar Arista";
            this.btnAgregarArista.UseVisualStyleBackColor = true;
            this.btnAgregarArista.Click += new System.EventHandler(this.btnAgregarArista_Click_1);
            // 
            // txtInicioArista
            // 
            this.txtInicioArista.Location = new System.Drawing.Point(88, 44);
            this.txtInicioArista.Name = "txtInicioArista";
            this.txtInicioArista.Size = new System.Drawing.Size(147, 20);
            this.txtInicioArista.TabIndex = 4;
            // 
            // txtFinArista
            // 
            this.txtFinArista.Location = new System.Drawing.Point(77, 77);
            this.txtFinArista.Name = "txtFinArista";
            this.txtFinArista.Size = new System.Drawing.Size(147, 20);
            this.txtFinArista.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inicio de Arista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fin de Arista";
            // 
            // pictureBoxGrafo
            // 
            this.pictureBoxGrafo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxGrafo.Location = new System.Drawing.Point(73, 132);
            this.pictureBoxGrafo.Name = "pictureBoxGrafo";
            this.pictureBoxGrafo.Size = new System.Drawing.Size(407, 213);
            this.pictureBoxGrafo.TabIndex = 8;
            this.pictureBoxGrafo.TabStop = false;
            // 
            // txtVerticeEliminar
            // 
            this.txtVerticeEliminar.Location = new System.Drawing.Point(472, 17);
            this.txtVerticeEliminar.Name = "txtVerticeEliminar";
            this.txtVerticeEliminar.Size = new System.Drawing.Size(147, 20);
            this.txtVerticeEliminar.TabIndex = 9;
            // 
            // btnEliminarVertice
            // 
            this.btnEliminarVertice.Location = new System.Drawing.Point(636, 5);
            this.btnEliminarVertice.Name = "btnEliminarVertice";
            this.btnEliminarVertice.Size = new System.Drawing.Size(116, 43);
            this.btnEliminarVertice.TabIndex = 10;
            this.btnEliminarVertice.Text = "Eliminar Vertice";
            this.btnEliminarVertice.UseVisualStyleBackColor = true;
            this.btnEliminarVertice.Click += new System.EventHandler(this.btnEliminarVertice_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Eliminar Vertice";
            // 
            // btnEliminarArista
            // 
            this.btnEliminarArista.Location = new System.Drawing.Point(646, 73);
            this.btnEliminarArista.Name = "btnEliminarArista";
            this.btnEliminarArista.Size = new System.Drawing.Size(116, 43);
            this.btnEliminarArista.TabIndex = 12;
            this.btnEliminarArista.Text = "Eliminar Arista";
            this.btnEliminarArista.UseVisualStyleBackColor = true;
            this.btnEliminarArista.Click += new System.EventHandler(this.btnEliminarArista_Click_1);
            // 
            // txtInicioEliminarArista
            // 
            this.txtInicioEliminarArista.Location = new System.Drawing.Point(493, 67);
            this.txtInicioEliminarArista.Name = "txtInicioEliminarArista";
            this.txtInicioEliminarArista.Size = new System.Drawing.Size(147, 20);
            this.txtInicioEliminarArista.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Eliminar Inicio Arista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Eliminar Fin Arista";
            // 
            // txtFinEliminarArista
            // 
            this.txtFinEliminarArista.Location = new System.Drawing.Point(493, 103);
            this.txtFinEliminarArista.Name = "txtFinEliminarArista";
            this.txtFinEliminarArista.Size = new System.Drawing.Size(147, 20);
            this.txtFinEliminarArista.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabListas.ResumeLayout(false);
            this.tabListas.PerformLayout();
            this.tabPilas.ResumeLayout(false);
            this.tabPilas.PerformLayout();
            this.tabColas.ResumeLayout(false);
            this.tabColas.PerformLayout();
            this.tabArboles.ResumeLayout(false);
            this.tabArboles.PerformLayout();
            this.tabGrafos.ResumeLayout(false);
            this.tabGrafos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabListas;
        private System.Windows.Forms.TabPage tabPilas;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.TextBox txtDatoPila;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnEstaVacia;
        private System.Windows.Forms.Button btnContarPila;
        private System.Windows.Forms.Button btnLimpiarPila;
        private System.Windows.Forms.ListView lstResultadoPila;
        private System.Windows.Forms.Button btnClonarPila;
        private System.Windows.Forms.TabPage tabColas;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnPeekCola;
        private System.Windows.Forms.Button btnEstaVaciaCola;
        private System.Windows.Forms.Button btnContarCola;
        private System.Windows.Forms.Button btnLimpiarCola;
        private System.Windows.Forms.Button btnOrdenarCola;
        private System.Windows.Forms.ListView lstResultadoCola;
        private System.Windows.Forms.TextBox txtDatoCola;
        private System.Windows.Forms.TabPage tabArboles;
        private System.Windows.Forms.TreeView treeViewArbol;
        private System.Windows.Forms.Button bnInsertarArbol;
        private System.Windows.Forms.Button btnEliminarArbol;
        private System.Windows.Forms.Button btnInorden;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.Button btnPostorden;
        private System.Windows.Forms.TextBox txtValorArbol;
        private System.Windows.Forms.TabPage tabGrafos;
        private System.Windows.Forms.TextBox txtVertice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarVertice;
        private System.Windows.Forms.TextBox txtInicioArista;
        private System.Windows.Forms.Button btnAgregarArista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinArista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxGrafo;
        private System.Windows.Forms.TextBox txtVerticeEliminar;
        private System.Windows.Forms.Button btnEliminarVertice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInicioEliminarArista;
        private System.Windows.Forms.Button btnEliminarArista;
        private System.Windows.Forms.TextBox txtFinEliminarArista;
        private System.Windows.Forms.Label label6;
    }
}

