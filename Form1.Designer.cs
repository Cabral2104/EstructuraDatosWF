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
            this.btnLimpiarPila = new System.Windows.Forms.Button();
            this.btnContarPila = new System.Windows.Forms.Button();
            this.btnEstaVacia = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.txtDatoPila = new System.Windows.Forms.TextBox();
            this.btnApilar = new System.Windows.Forms.Button();
            this.lstResultadoPila = new System.Windows.Forms.ListView();
            this.btnClonarPila = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabListas.SuspendLayout();
            this.tabPilas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabListas);
            this.tabControl1.Controls.Add(this.tabPilas);
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
            this.lstResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            // lstResultadoPila
            // 
            this.lstResultadoPila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstResultadoPila.HideSelection = false;
            this.lstResultadoPila.Location = new System.Drawing.Point(109, 144);
            this.lstResultadoPila.Name = "lstResultadoPila";
            this.lstResultadoPila.Size = new System.Drawing.Size(269, 179);
            this.lstResultadoPila.TabIndex = 7;
            this.lstResultadoPila.UseCompatibleStateImageBehavior = false;
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
    }
}

