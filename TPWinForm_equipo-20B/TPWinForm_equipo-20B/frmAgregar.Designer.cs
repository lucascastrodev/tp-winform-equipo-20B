namespace TPWinForm_equipo_20B
{
    partial class frmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblIDMarca = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboIDMarca = new System.Windows.Forms.ComboBox();
            this.cboIDCategoria = new System.Windows.Forms.ComboBox();
            this.textUrlImagen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticulo.Location = new System.Drawing.Point(11, 213);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(196, 30);
            this.lblCodArticulo.TabIndex = 1;
            this.lblCodArticulo.Text = "Codigo del Articulo:";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.Location = new System.Drawing.Point(106, 149);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(94, 30);
            this.lblNombreArticulo.TabIndex = 2;
            this.lblNombreArticulo.Text = "Nombre:";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(78, 276);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(126, 30);
            this.lblDescripcionArticulo.TabIndex = 3;
            this.lblDescripcionArticulo.Text = "Descripcion:";
            // 
            // lblIDMarca
            // 
            this.lblIDMarca.AutoSize = true;
            this.lblIDMarca.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMarca.Location = new System.Drawing.Point(99, 336);
            this.lblIDMarca.Name = "lblIDMarca";
            this.lblIDMarca.Size = new System.Drawing.Size(103, 30);
            this.lblIDMarca.TabIndex = 4;
            this.lblIDMarca.Text = "ID Marca:";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCategoria.Location = new System.Drawing.Point(69, 393);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(134, 30);
            this.lblIDCategoria.TabIndex = 5;
            this.lblIDCategoria.Text = "ID Categoria:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(124, 447);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(75, 30);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(233, 220);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(375, 26);
            this.txtCodigoArticulo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 153);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(375, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(233, 280);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(375, 26);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(233, 451);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(375, 26);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(444, 602);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 44);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(195, 602);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 44);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboIDMarca
            // 
            this.cboIDMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboIDMarca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboIDMarca.FormattingEnabled = true;
            this.cboIDMarca.Location = new System.Drawing.Point(233, 339);
            this.cboIDMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIDMarca.Name = "cboIDMarca";
            this.cboIDMarca.Size = new System.Drawing.Size(201, 28);
            this.cboIDMarca.TabIndex = 3;
            // 
            // cboIDCategoria
            // 
            this.cboIDCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboIDCategoria.FormattingEnabled = true;
            this.cboIDCategoria.Location = new System.Drawing.Point(233, 396);
            this.cboIDCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIDCategoria.Name = "cboIDCategoria";
            this.cboIDCategoria.Size = new System.Drawing.Size(201, 28);
            this.cboIDCategoria.TabIndex = 4;
            // 
            // textUrlImagen
            // 
            this.textUrlImagen.Location = new System.Drawing.Point(233, 501);
            this.textUrlImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUrlImagen.Name = "textUrlImagen";
            this.textUrlImagen.Size = new System.Drawing.Size(375, 26);
            this.textUrlImagen.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "UrlImagen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(636, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 203);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 802);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textUrlImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIDCategoria);
            this.Controls.Add(this.cboIDMarca);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblIDCategoria);
            this.Controls.Add(this.lblIDMarca);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.lblCodArticulo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(931, 1024);
            this.MinimumSize = new System.Drawing.Size(931, 858);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblIDMarca;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboIDMarca;
        private System.Windows.Forms.ComboBox cboIDCategoria;
        private System.Windows.Forms.TextBox textUrlImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}