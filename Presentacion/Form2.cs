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
        public frmAgregar(Articulos articulo) //Con este constructor sobrecargado creo la ventana
                                              //para modificar un articulo, ya que uso el mismo form de agregar
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
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

                if (articulo != null) //precargar articulo en el modificar
                {
                    txtCodigo1.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptarAgregarArt_Click(object sender, EventArgs e)// Botón Aceptar de la ventana de agregar artículos
        {
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }
                ArticulosNegocio articulosNegocio = new ArticulosNegocio();

                if (articulo == null) // si llego aca y esta nulo es porque toque modificar sino es agregar
                    articulo = new Articulos();
                articulo.Codigo = txtCodigo1.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Marca = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    articulosNegocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    articulosNegocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnCancelarAgregadoArt_Click(object sender, EventArgs e)// Botón Cancelar de la ventana agregar artículos
        {
            Close();
        }

        private bool ValidarCampos() //Validar que los txt esten completos
        {
            // Es necesario como minimo ingresar un Codigo y Nombre
            if (string.IsNullOrEmpty(txtCodigo1.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese Código y Artículo");
                return false;
            }


            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                // Si no se ingresó un precio, establecer el precio en 0 , esto es para que no me de un error al Aceptar
                txtPrecio.Text = "0";
            }

            return true;
        }
        private void cargarImagen(string imagen)
        {
            // por si no hay imagen en la bd, para que no falle el programa 
            try
            {
                pbxArticuloAgregar.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticuloAgregar.Load("https://imgs.search.brave.com/Jp6ngmaC-F_2y5_7UN2IF8HtgALS20IY1-qn-o5x8EA/rs:fit:860:0:0/g:ce/aHR0cHM6Ly90My5m/dGNkbi5uZXQvanBn/LzA0LzI5LzQyLzQy/LzM2MF9GXzQyOTQy/NDI3OV9kb2tFRndu/U29KZU9LcHF2VjF0/dFh1bThwaUVTc0Y1/TC5qcGc");
            }
        }
        private void txtImagenUrl_Leave(object sender, EventArgs e) // Con este evento, cuando salgo del txt cargo la imagen en el pbx
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) // Permito sólo números y una "," en el txt del Precio
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
