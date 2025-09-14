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
        private List<Articulo> listaarticulo;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaarticulo = negocio.listar();
            dgvArticulos.DataSource = listaarticulo;
            pbxarticulo.Load(listaarticulo[0].UrlImagen);
            ocultarcolumna();

  

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar altaProducto = new frmAgregar();
            altaProducto.ShowDialog();

            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = null;              // limpiar la grilla
            dgvArticulos.DataSource = negocio.listar();  // actualizar con los nuevos datos
        }

        private void ocultarcolumna()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["idArticulo"].Visible = false;
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
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
           
        }

        private void cargarImagen(string imagen) 
        {
            try
            {
                pbxarticulo.Load(imagen);
            }
            catch 
            {
                pbxarticulo.Load("https://media.istockphoto.com/id/1147544807/es/vector/no-imagen-en-miniatura-gr%C3%A1fico-vectorial.jpg?s=612x612&w=0&k=20&c=Bb7KlSXJXh3oSDlyFjIaCiB9llfXsgS7mHFZs6qUgVk=");
            }
        }


        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmDetalle detalleproducto = new FrmDetalle(seleccionado);
            detalleproducto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;

            string filtro = txbBuscar.Text;

            if (filtro != "")
            {
                listafiltrada = listaarticulo.FindAll(x => x.Nombre.ToUpper().Contains( filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }else
            { listafiltrada = listaarticulo; }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltrada;
            ocultarcolumna();
        }

        private void txbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;

            string filtro = txbBuscar.Text;

            if (filtro != "")
            {
                listafiltrada = listaarticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            { listafiltrada = listaarticulo; }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltrada;
            ocultarcolumna();
        }
    }
}
