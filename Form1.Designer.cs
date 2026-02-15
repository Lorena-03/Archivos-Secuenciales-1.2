namespace Archivos_secuenciales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvArchivo = new DataGridView();
            dgvPropiedades = new DataGridView();
            Propiedad = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            btnAbrir = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            btnRenombrar = new Button();
            btnEliminar = new Button();
            btnAgregarFila = new Button();
            btnEliminarFila = new Button();
            btnActualizar = new Button();
            btnExplorador = new Button();
            txtRutaArchivo = new TextBox();
            lblRuta = new Label();
            lblArchivo = new Label();
            lblPropiedades = new Label();
            groupBoxOperaciones = new GroupBox();
            btnCrearCarpeta = new Button();
            groupBoxEdicion = new GroupBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArchivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            groupBoxOperaciones.SuspendLayout();
            groupBoxEdicion.SuspendLayout();
            SuspendLayout();
            // 
            // dgvArchivo
            // 
            dgvArchivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchivo.Location = new Point(18, 112);
            dgvArchivo.Margin = new Padding(4, 5, 4, 5);
            dgvArchivo.Name = "dgvArchivo";
            dgvArchivo.RowHeadersWidth = 51;
            dgvArchivo.Size = new Size(823, 416);
            dgvArchivo.TabIndex = 0;
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.AllowUserToAddRows = false;
            dgvPropiedades.AllowUserToDeleteRows = false;
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Columns.AddRange(new DataGridViewColumn[] { Propiedad, Valor });
            dgvPropiedades.Location = new Point(891, 112);
            dgvPropiedades.Margin = new Padding(4, 5, 4, 5);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.ReadOnly = true;
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.Size = new Size(571, 416);
            dgvPropiedades.TabIndex = 1;
            // 
            // Propiedad
            // 
            Propiedad.HeaderText = "Propiedad";
            Propiedad.MinimumWidth = 6;
            Propiedad.Name = "Propiedad";
            Propiedad.ReadOnly = true;
            Propiedad.Width = 150;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 220;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(9, 36);
            btnAbrir.Margin = new Padding(4, 5, 4, 5);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(142, 50);
            btnAbrir.TabIndex = 2;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(160, 36);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(311, 36);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(142, 50);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Crear archivo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRenombrar
            // 
            btnRenombrar.Location = new Point(462, 36);
            btnRenombrar.Margin = new Padding(4, 5, 4, 5);
            btnRenombrar.Name = "btnRenombrar";
            btnRenombrar.Size = new Size(142, 50);
            btnRenombrar.TabIndex = 5;
            btnRenombrar.Text = "Renombrar";
            btnRenombrar.UseVisualStyleBackColor = true;
            btnRenombrar.Click += btnRenombrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(614, 36);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 50);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Archivo";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregarFila
            // 
            btnAgregarFila.Location = new Point(9, 36);
            btnAgregarFila.Margin = new Padding(4, 5, 4, 5);
            btnAgregarFila.Name = "btnAgregarFila";
            btnAgregarFila.Size = new Size(142, 50);
            btnAgregarFila.TabIndex = 7;
            btnAgregarFila.Text = "Agregar Fila";
            btnAgregarFila.UseVisualStyleBackColor = true;
            btnAgregarFila.Click += btnAgregarFila_Click;
            // 
            // btnEliminarFila
            // 
            btnEliminarFila.Location = new Point(160, 36);
            btnEliminarFila.Margin = new Padding(4, 5, 4, 5);
            btnEliminarFila.Name = "btnEliminarFila";
            btnEliminarFila.Size = new Size(142, 50);
            btnEliminarFila.TabIndex = 8;
            btnEliminarFila.Text = "Eliminar Fila";
            btnEliminarFila.UseVisualStyleBackColor = true;
            btnEliminarFila.Click += btnEliminarFila_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(311, 36);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(142, 50);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnExplorador
            // 
            btnExplorador.Location = new Point(982, 2);
            btnExplorador.Margin = new Padding(4, 5, 4, 5);
            btnExplorador.Name = "btnExplorador";
            btnExplorador.Size = new Size(142, 50);
            btnExplorador.TabIndex = 10;
            btnExplorador.Text = "Explorar...";
            btnExplorador.UseVisualStyleBackColor = true;
            btnExplorador.Click += btnExplorador_Click;
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.Location = new Point(98, 11);
            txtRutaArchivo.Margin = new Padding(4, 5, 4, 5);
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(875, 31);
            txtRutaArchivo.TabIndex = 11;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(18, 16);
            lblRuta.Margin = new Padding(4, 0, 4, 0);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(76, 25);
            lblRuta.TabIndex = 12;
            lblRuta.Text = "Archivo:";
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblArchivo.Location = new Point(18, 82);
            lblArchivo.Margin = new Padding(4, 0, 4, 0);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(202, 25);
            lblArchivo.TabIndex = 13;
            lblArchivo.Text = "Contenido del Archivo";
            // 
            // lblPropiedades
            // 
            lblPropiedades.AutoSize = true;
            lblPropiedades.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPropiedades.Location = new Point(891, 82);
            lblPropiedades.Margin = new Padding(4, 0, 4, 0);
            lblPropiedades.Name = "lblPropiedades";
            lblPropiedades.Size = new Size(219, 25);
            lblPropiedades.TabIndex = 14;
            lblPropiedades.Text = "Propiedades del Archivo";
            // 
            // groupBoxOperaciones
            // 
            groupBoxOperaciones.Controls.Add(btnCrearCarpeta);
            groupBoxOperaciones.Controls.Add(btnAbrir);
            groupBoxOperaciones.Controls.Add(btnGuardar);
            groupBoxOperaciones.Controls.Add(btnNuevo);
            groupBoxOperaciones.Controls.Add(btnRenombrar);
            groupBoxOperaciones.Controls.Add(btnEliminar);
            groupBoxOperaciones.Location = new Point(18, 539);
            groupBoxOperaciones.Margin = new Padding(4, 5, 4, 5);
            groupBoxOperaciones.Name = "groupBoxOperaciones";
            groupBoxOperaciones.Padding = new Padding(4, 5, 4, 5);
            groupBoxOperaciones.Size = new Size(853, 335);
            groupBoxOperaciones.TabIndex = 15;
            groupBoxOperaciones.TabStop = false;
            groupBoxOperaciones.Text = "Operaciones de Archivo";
            // 
            // btnCrearCarpeta
            // 
            btnCrearCarpeta.Location = new Point(9, 96);
            btnCrearCarpeta.Margin = new Padding(4, 5, 4, 5);
            btnCrearCarpeta.Name = "btnCrearCarpeta";
            btnCrearCarpeta.Size = new Size(142, 50);
            btnCrearCarpeta.TabIndex = 7;
            btnCrearCarpeta.Text = "Crear Carpeta";
            btnCrearCarpeta.UseVisualStyleBackColor = true;
            btnCrearCarpeta.Click += btnCrearCarpeta_Click;
            // 
            // groupBoxEdicion
            // 
            groupBoxEdicion.Controls.Add(btnBuscar);
            groupBoxEdicion.Controls.Add(btnAgregarFila);
            groupBoxEdicion.Controls.Add(btnEliminarFila);
            groupBoxEdicion.Controls.Add(btnActualizar);
            groupBoxEdicion.Location = new Point(901, 561);
            groupBoxEdicion.Margin = new Padding(4, 5, 4, 5);
            groupBoxEdicion.Name = "groupBoxEdicion";
            groupBoxEdicion.Padding = new Padding(4, 5, 4, 5);
            groupBoxEdicion.Size = new Size(529, 200);
            groupBoxEdicion.TabIndex = 16;
            groupBoxEdicion.TabStop = false;
            groupBoxEdicion.Text = "Edición de Contenido";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(9, 96);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(142, 50);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(groupBoxEdicion);
            Controls.Add(groupBoxOperaciones);
            Controls.Add(lblPropiedades);
            Controls.Add(lblArchivo);
            Controls.Add(lblRuta);
            Controls.Add(txtRutaArchivo);
            Controls.Add(btnExplorador);
            Controls.Add(dgvPropiedades);
            Controls.Add(dgvArchivo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Gestor de Archivos Secuenciales";
            ((System.ComponentModel.ISupportInitialize)dgvArchivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            groupBoxOperaciones.ResumeLayout(false);
            groupBoxEdicion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivo;
        private System.Windows.Forms.DataGridView dgvPropiedades;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRenombrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarFila;
        private System.Windows.Forms.Button btnEliminarFila;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnExplorador;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Label lblPropiedades;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.GroupBox groupBoxEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button btnCrearCarpeta;
        private System.Windows.Forms.Button btnBuscar;
    }
}
