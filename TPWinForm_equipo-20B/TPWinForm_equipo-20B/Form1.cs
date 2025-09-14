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
    public partial class frmPrincipal : Form
    {
        public List<Articulo> listaarticulo = new List<Articulo>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar();
  

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar altaProducto = new frmAgregar();
            altaProducto.ShowDialog();

            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = null;              // limpiar la grilla
            dgvArticulos.DataSource = negocio.listar();  // actualizar con los nuevos datos
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta =  MessageBox.Show("¿Estas seguro que querés eliminar? No podrás volver atrás","Eliminando",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                     seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                     negocio.eliminar(seleccionado.idArticulo);
                     dgvArticulos.DataSource = negocio.listar();
                }
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar altaProducto = new frmAgregar(seleccionado);
            altaProducto.ShowDialog();

            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = null;              // limpiar la grilla
            dgvArticulos.DataSource = negocio.listar();  // actualizar con los nuevos datos

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar altaProducto = new frmAgregar(seleccionado);
            altaProducto.ShowDialog();
        }
    }
}
