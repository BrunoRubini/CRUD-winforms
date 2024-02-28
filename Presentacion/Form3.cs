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
    public partial class frmAvanzado : Form
    {
        private List<Articulos> listaArticulos;
        public frmAvanzado()
        {
            InitializeComponent();
        }
        private void frmAvanzado_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            //Data grid view para poder ver las tablas que traje
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvDatosAvanzados.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void ocultarColumnas()
        {
            dgvDatosAvanzados.Columns["ImagenUrl"].Visible = false;
            dgvDatosAvanzados.Columns["Id"].Visible = false;

        }
        public void cargarImagen(string imagen)
        {
            // por si no hay imagen en la bd, para que no falle el programa cargo una imagen desde la web
            try
            {
                pbxAvanzado.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAvanzado.Load("https://imgs.search.brave.com/Jp6ngmaC-F_2y5_7UN2IF8HtgALS20IY1-qn-o5x8EA/rs:fit:860:0:0/g:ce/aHR0cHM6Ly90My5m/dGNkbi5uZXQvanBn/LzA0LzI5LzQyLzQy/LzM2MF9GXzQyOTQy/NDI3OV9kb2tFRndu/U29KZU9LcHF2VjF0/dFh1bThwaUVTc0Y1/TC5qcGc");
            }
        }

        private void dgvDatosAvanzados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatosAvanzados.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvDatosAvanzados.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        
    }
}
