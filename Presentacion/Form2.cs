using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmAgregar : Form
    {
        private Articulos articulo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                ArticulosNegocio articulosNegocio = new ArticulosNegocio();
                articulo = new Articulos();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Marca = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulosNegocio.agregar(articulo);
                MessageBox.Show("Agregado Exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            try
            {
                cboMarca.DataSource = marcasNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriasNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                /* if (pokemon != null) //precargar pokemon en el modificar
                 {
                     txtNumero.Text = pokemon.Numero.ToString();
                     txtNombre.Text = pokemon.Nombre;
                     txtDescripcion.Text = pokemon.Descripcion;
                     txtUrlImagen.Text = pokemon.UrlImagen;
                     cargarImagen(pokemon.UrlImagen);
                     cboTipo.SelectedValue = pokemon.Tipo.Id;
                     cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                 }*/
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, coma y backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Permitir solo una coma
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
