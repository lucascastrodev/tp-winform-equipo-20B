namespace TPWinForm_equipo_20B
{
    partial class FormDetalle
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.cboIDMarca = new System.Windows.Forms.ComboBox();
            this.cboIDCategoria = new System.Windows.Forms.ComboBox();
            this.lblIDMarca = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(348, 140);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.Location = new System.Drawing.Point(240, 139);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(77, 23);
            this.lblNombreArticulo.TabIndex = 3;
            this.lblNombreArticulo.Text = "Nombre:";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(348, 186);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(333, 22);
            this.txtCodigoArticulo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(348, 233);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(333, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticulo.Location = new System.Drawing.Point(151, 187);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(161, 23);
            this.lblCodArticulo.TabIndex = 6;
            this.lblCodArticulo.Text = "Codigo del Articulo:";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(213, 234);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(102, 23);
            this.lblDescripcionArticulo.TabIndex = 7;
            this.lblDescripcionArticulo.Text = "Descripcion:";
            // 
            // cboIDMarca
            // 
            this.cboIDMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboIDMarca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboIDMarca.FormattingEnabled = true;
            this.cboIDMarca.Location = new System.Drawing.Point(348, 283);
            this.cboIDMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIDMarca.Name = "cboIDMarca";
            this.cboIDMarca.Size = new System.Drawing.Size(179, 24);
            this.cboIDMarca.TabIndex = 8;
            // 
            // cboIDCategoria
            // 
            this.cboIDCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboIDCategoria.FormattingEnabled = true;
            this.cboIDCategoria.Location = new System.Drawing.Point(348, 329);
            this.cboIDCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIDCategoria.Name = "cboIDCategoria";
            this.cboIDCategoria.Size = new System.Drawing.Size(179, 24);
            this.cboIDCategoria.TabIndex = 9;
            // 
            // lblIDMarca
            // 
            this.lblIDMarca.AutoSize = true;
            this.lblIDMarca.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMarca.Location = new System.Drawing.Point(232, 286);
            this.lblIDMarca.Name = "lblIDMarca";
            this.lblIDMarca.Size = new System.Drawing.Size(83, 23);
            this.lblIDMarca.TabIndex = 10;
            this.lblIDMarca.Text = "ID Marca:";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCategoria.Location = new System.Drawing.Point(204, 331);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(110, 23);
            this.lblIDCategoria.TabIndex = 11;
            this.lblIDCategoria.Text = "ID Categoria:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(348, 373);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(333, 22);
            this.txtPrecio.TabIndex = 12;
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 657);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblIDCategoria);
            this.Controls.Add(this.lblIDMarca);
            this.Controls.Add(this.cboIDCategoria);
            this.Controls.Add(this.cboIDMarca);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.lblCodArticulo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDetalle";
            this.Text = "FormDetalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.ComboBox cboIDMarca;
        private System.Windows.Forms.ComboBox cboIDCategoria;
        private System.Windows.Forms.Label lblIDMarca;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}