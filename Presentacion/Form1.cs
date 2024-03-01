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
        private void cargar() // Cargar el dataGridView principal
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvDatos.DataSource = listaArticulos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvDatos.Columns["ImagenUrl"].Visible = false;
            dgvDatos.Columns["Id"].Visible = false;

        }
        
        private void btnAgregarPrincipal_Click(object sender, EventArgs e) // Botón de Agregar, abre el formulario de agregar artículo 
        {
            frmAgregar alta = new frmAgregar();
            alta.ShowDialog();
            cargar();
        }
        private void btnModificarPrincipal_Click(object sender, EventArgs e) // Botón de Modificar, abre el formulario de modificar artículo
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvDatos.CurrentRow.DataBoundItem;

            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
        private void btnEliminarPrincipal_Click(object sender, EventArgs e)// Botón de Eliminar
        {
            eliminar();
        }

        private void btnAvanzadosPrincipal_Click(object sender, EventArgs e)// Abrir formulario Avanzado
        {
            frmAvanzado avanzado = new frmAvanzado();
            avanzado.ShowDialog();
            cargar();
        }
        private void eliminar() // Funcion para Seleccionar el artículo , preguntar y luego llamar a la método eliminar pasando su seleccionado.Id como parámetro
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos seleccionado;
            seleccionado = (Articulos)dgvDatos.CurrentRow.DataBoundItem; // Tomo el artículo seleccionado en ese momento en el dgv
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
        private void txtBuscarArticulo_Enter(object sender, EventArgs e) // Cambia el texto de fondo del textBox
        {
            if (txtBuscarArticulo.Text == "Ingrese nombre, marca o categoría")
                txtBuscarArticulo.Text = "";
        }
        private void txtBuscarArticulo_TextChanged(object sender, EventArgs e) // Filtra la lista mientras escribo, es un filtro rápido
        {
            List<Articulos> listaFiltrada;
            string filtro = txtBuscarArticulo.Text;
            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        
    }
}
