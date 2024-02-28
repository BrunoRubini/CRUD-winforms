using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        private List<Articulos> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            cargar();

            dgvDatos.Columns["Precio"].DefaultCellStyle.Format = "N2"; // formatear precio a 2 decimales


        }
        private void cargar()
        {
            //Data grid view para poder ver las tablas que traje
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvDatos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        public void cargarImagen(string imagen)
        {
            // por si no hay imagen en la bd, para que no falle el programa cargo una imagen desde la web
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://imgs.search.brave.com/Jp6ngmaC-F_2y5_7UN2IF8HtgALS20IY1-qn-o5x8EA/rs:fit:860:0:0/g:ce/aHR0cHM6Ly90My5m/dGNkbi5uZXQvanBn/LzA0LzI5LzQyLzQy/LzM2MF9GXzQyOTQy/NDI3OV9kb2tFRndu/U29KZU9LcHF2VjF0/dFh1bThwaUVTc0Y1/TC5qcGc");
            }
        }
        private void ocultarColumnas()
        {
            dgvDatos.Columns["ImagenUrl"].Visible = false;
            dgvDatos.Columns["Id"].Visible = false;

        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        { // Con SelectionChanged actualizo la imagen cuando hago click en otro articulo en el dgv
            if (dgvDatos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvDatos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar alta = new frmAgregar();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvDatos.CurrentRow.DataBoundItem;

            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos seleccionado;
            seleccionado = (Articulos)dgvDatos.CurrentRow.DataBoundItem;
            try
            {
                DialogResult respuesta = MessageBox.Show($"Atención, desea eliminar permanentemente el artículo: \nCódigo: {seleccionado.Codigo} \nNombre: {seleccionado.Nombre}", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Eliminado Correctamente");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscarArticulo_Enter(object sender, EventArgs e)
        {
            if (txtBuscarArticulo.Text == "Buscar Artículo")
                txtBuscarArticulo.Text = "";
        }

        private void txtBuscarArticulo_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txtBuscarArticulo.Text;
            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnAvanzados_Click(object sender, EventArgs e)
        {
            frmAvanzado avanzado = new frmAvanzado();
            avanzado.ShowDialog();
            cargar();
        }

        
    }
}
