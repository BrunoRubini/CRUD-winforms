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

            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
            cboCampo.SelectedIndex = 0; // con esto preselecciono el primero elemento del combo box
            cboCriterio.SelectedIndex = 0;
            cboOrdenCampo.Items.Add("Código");
            cboOrdenCampo.Items.Add("Marca");
            cboOrdenCampo.Items.Add("Categoría");
            cboOrdenCampo.Items.Add("Precio");
            cboOrdenCampo.SelectedIndex = 0;
            cboOrdenCriterio.Items.Add("Ascendente");
            cboOrdenCriterio.Items.Add("Descendente");
            cboOrdenCriterio.SelectedIndex = 0;

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

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Nombre")
            {
                cboCriterio.DataSource = null; // Limpiar DataSource primero
                cboCriterio.Items.Clear(); // Luego limpiar los Items , necesito ésto para que no se rompa el programa por los DataSource que utilizo luego
                cboCriterio.Items.Add("Contiene");
            }
            else if (opcion == "Descripción")
            {
                cboCriterio.DataSource = null;
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
            else if (opcion == "Marca")
            {
                cboCriterio.DataSource = marcasNegocio.listar();
                cboCriterio.DisplayMember = "Marca";
            }
            else
            {
                cboCriterio.DataSource = categoriasNegocio.listar();
                cboCriterio.DisplayMember = "Categoria";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvDatosAvanzados.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private bool validarFiltro()
        {

            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar");
                return true;
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!(char.IsNumber(c)))
                    return false;
            }
            return true;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {

                string campo = cboOrdenCampo.SelectedItem.ToString();
                string criterio = cboOrdenCriterio.SelectedItem.ToString();

                dgvDatosAvanzados.DataSource = negocio.ordenar(campo, criterio);

            }
            catch (Exception ex)
            {
                throw ex;
               // MessageBox.Show(ex.ToString());
            }
        }
    }
}
