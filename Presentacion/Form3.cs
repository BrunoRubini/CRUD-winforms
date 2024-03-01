using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
            //
            cboCampo1.Items.Add("Nombre");
            cboCampo1.Items.Add("Descripción");
            cboCampo1.Items.Add("Marca");
            cboCampo1.Items.Add("Categoría");
            cboCampo1.SelectedIndex = 1; // con esto preselecciono vacío
            cboCriterio1.SelectedIndex = -1;
            //
            cboOrdenCampo.Items.Add("Código");
            cboOrdenCampo.Items.Add("Marca");
            cboOrdenCampo.Items.Add("Categoría");
            cboOrdenCampo.Items.Add("Precio");
            cboOrdenCampo.SelectedIndex = 0;

            cboOrdenCriterio.Items.Add("Ascendente");
            cboOrdenCriterio.Items.Add("Descendente");
            cboOrdenCriterio.SelectedIndex = 0;
            //
            cboCampo1.Enabled = false;
            cboCriterio1.Enabled = false;
            txtFiltroAvanzado1.Enabled = false;
            //
            cboCampo.Enabled = false;
            cboCriterio.Enabled = false;
            txtFiltroAvanzado.Enabled = false;
            //
            cboCampo1.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            btnBuscar.Enabled = false;
            btnConfirmar.Enabled = false;
            //
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            cboPrecioMarcas.DataSource = marcasNegocio.listar();
            //cboPrecioMarcas.ValueMember = "Id";
            cboPrecioMarcas.DisplayMember = "Descripcion";
            cboPrecioCategorias.DataSource = categoriasNegocio.listar();
            //cboPrecioCategorias.ValueMember = "Id";
            cboPrecioCategorias.DisplayMember = "Descripcion";
            rdbSubirPrecio.Checked = true;
            //
            btnConfirmar.Enabled = false;
            //

        }
        private void cargar() // Cargar dgvDatosAvanzados
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

        private void dgvDatosAvanzados_SelectionChanged(object sender, EventArgs e) // para cargar imagen cuando cambio de articulo en el dgv
        {
            if (dgvDatosAvanzados.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvDatosAvanzados.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e) //CBO FILTRO BUSQUEDA 1
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
        private void cboCampo1_SelectedIndexChanged(object sender, EventArgs e) //CBO FILTRO BUSQUEDA 2
        {
            MarcasNegocio marcasNegocio1 = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio1 = new CategoriasNegocio();
            string opcion = cboCampo1.SelectedItem.ToString();
            if (opcion == "Nombre")
            {
                cboCriterio1.DataSource = null; // Limpiar DataSource primero
                cboCriterio1.Items.Clear(); // Luego limpiar los Items , necesito ésto para que no se rompa el programa por los DataSource que utilizo luego
                cboCriterio1.Items.Add("Contiene");
            }
            else if (opcion == "Descripción")
            {
                cboCriterio1.DataSource = null;
                cboCriterio1.Items.Clear();
                cboCriterio1.Items.Add("Comienza con");
                cboCriterio1.Items.Add("Termina con");
                cboCriterio1.Items.Add("Contiene");
            }
            else if (opcion == "Marca")
            {
                cboCriterio1.DataSource = marcasNegocio1.listar();
                cboCriterio1.DisplayMember = "Marca";
            }
            else
            {
                cboCriterio1.DataSource = categoriasNegocio1.listar();
                cboCriterio1.DisplayMember = "Categoria";
            }

        }
        private void cboCampo1_DropDown(object sender, EventArgs e)// DESHABILITAR Opciones Segun el campo del primer filtro
        {

            string opcionSeleccionada = cboCampo.SelectedItem.ToString();

            if (opcionSeleccionada == "Marca")
            {
                cboCampo1.Items.Remove("Marca");
            }
            else
            {
                if (!cboCampo1.Items.Contains("Marca"))
                {
                    cboCampo1.Items.Add("Marca");
                }
            }
            if (opcionSeleccionada == "Categoría")
            {
                cboCampo1.Items.Remove("Categoría");
            }
            else
            {
                if (!cboCampo1.Items.Contains("Categoría"))
                {
                    cboCampo1.Items.Add("Categoría");
                }
            }
            if (opcionSeleccionada == "Nombre")
            {
                cboCampo1.Items.Remove("Nombre");
            }
            else
            {
                if (!cboCampo1.Items.Contains("Nombre"))
                {
                    cboCampo1.Items.Add("Nombre");
                }
            }
            if (opcionSeleccionada == "Descripción")
            {
                cboCampo1.Items.Remove("Descripción");
            }
            else
            {
                if (!cboCampo1.Items.Contains("Descripción"))
                {
                    cboCampo1.Items.Add("Descripción");
                }
            }
        }

        private void cboCampo_DropDown(object sender, EventArgs e) // DESHABILITAR Opciones Segun el campo del segundo filtro
        {

            string opcionSeleccionada = cboCampo1.SelectedItem.ToString();

            if (opcionSeleccionada == "Marca")
            {
                cboCampo.Items.Remove("Marca");
            }
            else
            {
                if (!cboCampo.Items.Contains("Marca"))
                {
                    cboCampo.Items.Add("Marca");
                }
            }
            if (opcionSeleccionada == "Categoría")
            {
                cboCampo.Items.Remove("Categoría");
            }
            else
            {
                if (!cboCampo.Items.Contains("Categoría"))
                {
                    cboCampo.Items.Add("Categoría");
                }
            }
            if (opcionSeleccionada == "Nombre")
            {
                cboCampo.Items.Remove("Nombre");
            }
            else
            {
                if (!cboCampo.Items.Contains("Nombre"))
                {
                    cboCampo.Items.Add("Nombre");
                }
            }
            if (opcionSeleccionada == "Descripción")
            {
                cboCampo.Items.Remove("Descripción");
            }
            else
            {
                if (!cboCampo.Items.Contains("Descripción"))
                {
                    cboCampo.Items.Add("Descripción");
                }
            }
        }
        private void ckbFiltro1_CheckedChanged(object sender, EventArgs e) //checkBox de filtro busqueda 1
        {
            if (ckbFiltro1.Checked)
            {
                cboCampo.Enabled = true;
                cboCriterio.Enabled = true;
                txtFiltroAvanzado.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else
            {
                cboCampo.Enabled = false;
                cboCriterio.Enabled = false;
                txtFiltroAvanzado.Enabled = false;
                ckbFiltro2.Checked = false;
                btnBuscar.Enabled = false; // Deshabilito el boton de Buscar ya que no estan puestos los parametros
            }
        }
        private void ckbFiltro2_CheckedChanged(object sender, EventArgs e) //checkBox de filtro de busqueda 2
        {
            if (!ckbFiltro1.Checked)
            {
                cboCampo1.Enabled = false;
                cboCriterio1.Enabled = false;
                txtFiltroAvanzado1.Enabled = false;
                ckbFiltro2.Checked = false;
                return;
            }

            if (ckbFiltro2.Checked && ckbFiltro1.Checked)
            {
                cboCampo1.Enabled = true;
                cboCriterio1.Enabled = true;
                txtFiltroAvanzado1.Enabled = true;

            }
            else
            {
                cboCampo1.Enabled = false;
                cboCriterio1.Enabled = false;
                txtFiltroAvanzado1.Enabled = false;
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e) //btn BUSCAR
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                int cantidadArticulosEncontrados = 0;
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                if (ckbFiltro2.Checked)
                {
                    string campo1 = cboCampo1.SelectedItem.ToString();
                    string criterio1 = cboCriterio1.SelectedItem.ToString();
                    string filtro1 = txtFiltroAvanzado1.Text;
                    dgvDatosAvanzados.DataSource = negocio.filtrar(campo, criterio, filtro, campo1, criterio1, filtro1);
                    cantidadArticulosEncontrados = dgvDatosAvanzados.RowCount; // Con ésto obtengo el numero de filas del dgv cargado

                }
                else
                {
                    dgvDatosAvanzados.DataSource = negocio.filtrar(campo, criterio, filtro);
                    cantidadArticulosEncontrados = dgvDatosAvanzados.RowCount;
                }

                MessageBox.Show(cantidadArticulosEncontrados + " artículos encontrados");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private bool validarFiltro() // Valido que se seleccione una opcion para "Nombre" y "Descripción" al momento de buscar
        {
            if ((ckbFiltro1.Checked && cboCriterio.SelectedIndex < 0) ||
                (ckbFiltro2.Checked && cboCriterio1.SelectedIndex < 0))
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar");
                return true;
            }

            return false;
        }

        private void btnOrdenar_Click(object sender, EventArgs e) //Boton para Ordenar el dgv
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtValorPrecio_KeyPress(object sender, KeyPressEventArgs e) //Solo admite números el txtValorPrecio
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni el carácter de retroceso, cancela la pulsación
                e.Handled = true;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e) // btn Acepter Modificar precios
        {

            try
            {


                if (!ckbPorcentaje.Checked && !ckbValor.Checked)
                {

                    MessageBox.Show("Por favor seleccione valor o porcentaje");
                }
                else if (!ckbMarcas.Checked && !ckbCategorias.Checked)
                {
                    MessageBox.Show("Por favor seleccione marca y/o categoría");
                }
                else if (string.IsNullOrEmpty(txtValorPrecio.Text))
                {
                    MessageBox.Show("Por favor ingrese un valor");
                    txtValorPrecio.BackColor = Color.Red;
                }
                else
                {
                    cargarDgvPrecios();
                    btnConfirmar.Enabled = true;
                    //mostrar informa
                    txtInformeModificacion.Text = construirInforme();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private decimal construirPrecioModificado() // Devuelvo el valor del precio listo para usar en la modificacion de precios
        {

            decimal nuevoPrecio;

            nuevoPrecio = decimal.Parse(txtValorPrecio.Text); // leo el valor del textBox

            if (rdbSubirPrecio.Checked)
            {
                if (ckbPorcentaje.Checked) // Si Porcentaje esta marcado :
                {
                    nuevoPrecio = 1 + nuevoPrecio / 100;
                }
            }
            else // Entonces esta marcado Descuento
            {
                if (ckbPorcentaje.Checked)
                {
                    nuevoPrecio = 1 - nuevoPrecio / 100;
                }
                else // tambien paso a negativo nuevoPrecio por si esta marcado Valor
                    nuevoPrecio = -1 * nuevoPrecio;
            }


            return nuevoPrecio;
        }
        private string porcentajeOvalor() // Funcion para devolver un parametro y luego sea utilizado en modificarPrecios()
        {
            if (ckbPorcentaje.Checked)
            {
                return "porcentaje";
            }
            else
            {
                return "valor";
            }
        }

        private string categoriaSelecta() //Funcion para devolver un parametro de categoria y luego sea utilizado en modificarPrecios()
        {
            if (ckbCategorias.Checked)
            {
                return cboPrecioCategorias.SelectedItem.ToString();
            }
            else
                return "";
        }
        private string marcaSelecta()//Funcion para devolver un parametro de marca y luego sea utilizado en modificarPrecios()
        {
            if (ckbMarcas.Checked)
            {
                return cboPrecioMarcas.SelectedItem.ToString();
            }
            else
                return "";
        }

        private void ckbPorcentaje_CheckedChanged(object sender, EventArgs e) // Evento para cambiar un checkBox 
        {
            if (ckbPorcentaje.Checked)
            {
                // Si checkBox de porcentaje está marcado, desmarca checkBox de Valor
                ckbValor.Checked = false;
                txtValorPrecio.MaxLength = 3; // como maximo dejo escribir 3 digitos
            }
        }

        private void ckbValor_CheckedChanged_1(object sender, EventArgs e) //Evento para cambiar un checkBox
        {
            if (ckbValor.Checked)
            {
                // Si checkBox de Valor está marcado, desmarca checkBox de Porcentaje
                ckbPorcentaje.Checked = false;
                txtValorPrecio.MaxLength = 9; // como maximo dejo escribir 9 digitos
            }
        }

        private void btnReiniciarFiltro_Click(object sender, EventArgs e) // Boton para reiniciar filtros de busqueda
        {
            ckbFiltro1.Checked = false;  // reinicio los filtros con el checkBox del filtro principal
            cargar(); // llamo al metodo cargar para que vuelva a listar en el dgv
        }
        private void cargarDgvPrecios() // Cargar el dgv de los precios a modificar
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                int articulosEncontrados = 0;
                string categoria = categoriaSelecta(); // La funcion me devuelve "Televisores" por ejemplo
                string marca = marcaSelecta(); // La funcion me devuelve "Huawei" por ejemplo
                if (ckbMarcas.Checked && ckbCategorias.Checked)
                {
                    dgvPreciosModificar.DataSource = negocio.filtrar("Marca", marca, "", "Categoria", categoria, ""); //Por si paso una Marca y Categoria
                    articulosEncontrados = dgvPreciosModificar.RowCount;
                }
                else if (ckbMarcas.Checked) // Si paso solo la marca
                {
                    dgvPreciosModificar.DataSource = negocio.filtrar("Marca", marca, "");
                    articulosEncontrados = dgvPreciosModificar.RowCount;
                }
                else if (ckbCategorias.Checked) // Si paso solo la categoria
                {
                    dgvPreciosModificar.DataSource = negocio.filtrar("Categoria", categoria, "");
                    articulosEncontrados = dgvPreciosModificar.RowCount;
                }

                dgvPreciosModificar.Columns["ImagenUrl"].Visible = false;
                dgvPreciosModificar.Columns["Id"].Visible = false;
                dgvPreciosModificar.Columns["Descripcion"].Visible = false;
                MessageBox.Show("Articulos encontrados: " + articulosEncontrados);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e) //Boton que confirma la modificacion total de precios
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            int articulosEncontrados = 0;
            articulosEncontrados = dgvPreciosModificar.RowCount;
            decimal nuevoPrecio = construirPrecioModificado(); // valor del txtPrecio ya validado , positivo si es un aumento,negativo un descuento
            string respuesta = porcentajeOvalor(); // La funcion devuelve si es un porcentaje o un valor
            string categoria = categoriaSelecta(); // La funcion me devuelve "Televisores" por ejemplo
            string marca = marcaSelecta();// La funcion me devuelve "Huawei" por ejemplo
            DialogResult respuestaCartel = MessageBox.Show("Desea modificar el precio de: " + articulosEncontrados + " artículos encontrados?", "Modificando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuestaCartel == DialogResult.Yes)
            {
                negocio.modificarPrecios(marca, categoria, nuevoPrecio, respuesta);// FUNCION MODIFICAR PRECIOS TOTALES
                cargarDgvPrecios();
            }
            else
                MessageBox.Show("Cancelando");

        }
        private string construirInforme() // Para armar el txtInforme de la configuracion para modificar los precios
        {
            string cadena = "Aumento ";
            if (rdbBajarPrecio.Checked)
            {
                cadena = "Descuento ";
            }
            if (ckbPorcentaje.Checked)
            {
                cadena += txtValorPrecio.Text + "%";
            }
            else
                cadena += txtValorPrecio.Text + "$";
            if (ckbMarcas.Checked && ckbCategorias.Checked)
            {
                cadena += " - Marca: " + cboPrecioMarcas.Text + " - Categoría: " + cboPrecioCategorias.Text;
            }
            else if (ckbMarcas.Checked)
            {
                cadena += " - Marca: " + cboPrecioMarcas.Text;
            }
            else
            {
                cadena += " - Categoría: " + cboPrecioCategorias.Text;
            }
            return cadena;
        }
    }
}
