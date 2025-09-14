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
    public partial class frmAgregar : Form
    {

        private Articulo articulo = null;

        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoArticulo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                cboIDMarca.SelectedValue == null ||
                cboIDCategoria.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, agregue todos los datos del artículo.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Ingresá un precio válido.");
                return false;
            }

            return true;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                
                if (!ValidarCampos())
                    return;

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = new Marca { IdMarca = (int)cboIDMarca.SelectedValue };
                articulo.Categoria = new Categoria { IdCategoria = (int)cboIDCategoria.SelectedValue };
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.idArticulo != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
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
    }

}
