using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_20B
{
    public partial class FrmDetalle : Form
    {
        private Articulo articulo = null;
        public FrmDetalle()
        {
            InitializeComponent();
        }


        public FrmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            MarcaNegocio mNegocio = new MarcaNegocio();
            cboIDMarca.DataSource = mNegocio.listar();
            cboIDMarca.DisplayMember = "Descripcion";
            cboIDMarca.ValueMember = "IdMarca";
            cboIDMarca.SelectedIndex = 0;

            CategoriaNegocio cNegocio = new CategoriaNegocio();
            cboIDCategoria.DataSource = cNegocio.listar();
            cboIDCategoria.DisplayMember = "Descripcion";
            cboIDCategoria.ValueMember = "IdCategoria";
            cboIDCategoria.SelectedIndex = 0;

            if (articulo != null)
            {
                txtCodigoArticulo.Text = articulo.Codigo.ToString();
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                cboIDCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                cboIDMarca.SelectedValue = articulo.Marca.IdMarca;
                txtPrecio.Text = articulo.Precio.ToString();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
