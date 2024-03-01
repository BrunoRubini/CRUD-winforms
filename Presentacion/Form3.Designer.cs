namespace Presentacion
{
    partial class frmAvanzado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbxAvanzado = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvDatosAvanzados = new System.Windows.Forms.DataGridView();
            this.lblListaArticulos = new System.Windows.Forms.Label();
            this.cboCampo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboCriterio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFiltroAvanzado = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrdenar = new Guna.UI2.WinForms.Guna2Button();
            this.cboOrdenCampo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboOrdenCriterio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gpbModificarPrecios = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPreciosModificar = new System.Windows.Forms.DataGridView();
            this.btnAplicar = new Guna.UI2.WinForms.Guna2Button();
            this.ckbValor = new System.Windows.Forms.CheckBox();
            this.ckbPorcentaje = new System.Windows.Forms.CheckBox();
            this.txtValorPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboPrecioCategorias = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboPrecioMarcas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ckbMarcas = new System.Windows.Forms.CheckBox();
            this.ckbCategorias = new System.Windows.Forms.CheckBox();
            this.rdbBajarPrecio = new System.Windows.Forms.RadioButton();
            this.rdbSubirPrecio = new System.Windows.Forms.RadioButton();
            this.ckbFiltro1 = new System.Windows.Forms.CheckBox();
            this.ckbFiltro2 = new System.Windows.Forms.CheckBox();
            this.txtFiltroAvanzado1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboCriterio1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboCampo1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnReiniciarFiltro = new Guna.UI2.WinForms.Guna2Button();
            this.txtInformeModificacion = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvanzado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAvanzados)).BeginInit();
            this.gpbModificarPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAvanzado
            // 
            this.pbxAvanzado.BorderRadius = 11;
            this.pbxAvanzado.ImageRotate = 0F;
            this.pbxAvanzado.Location = new System.Drawing.Point(692, 39);
            this.pbxAvanzado.Name = "pbxAvanzado";
            this.pbxAvanzado.Size = new System.Drawing.Size(237, 197);
            this.pbxAvanzado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvanzado.TabIndex = 0;
            this.pbxAvanzado.TabStop = false;
            // 
            // dgvDatosAvanzados
            // 
            this.dgvDatosAvanzados.AllowUserToResizeColumns = false;
            this.dgvDatosAvanzados.AllowUserToResizeRows = false;
            this.dgvDatosAvanzados.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvDatosAvanzados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosAvanzados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvDatosAvanzados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosAvanzados.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvDatosAvanzados.EnableHeadersVisualStyles = false;
            this.dgvDatosAvanzados.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDatosAvanzados.Location = new System.Drawing.Point(12, 39);
            this.dgvDatosAvanzados.MultiSelect = false;
            this.dgvDatosAvanzados.Name = "dgvDatosAvanzados";
            this.dgvDatosAvanzados.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosAvanzados.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvDatosAvanzados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosAvanzados.Size = new System.Drawing.Size(674, 197);
            this.dgvDatosAvanzados.TabIndex = 1;
            this.dgvDatosAvanzados.SelectionChanged += new System.EventHandler(this.dgvDatosAvanzados_SelectionChanged);
            // 
            // lblListaArticulos
            // 
            this.lblListaArticulos.AutoSize = true;
            this.lblListaArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaArticulos.Location = new System.Drawing.Point(41, 16);
            this.lblListaArticulos.Name = "lblListaArticulos";
            this.lblListaArticulos.Size = new System.Drawing.Size(104, 16);
            this.lblListaArticulos.TabIndex = 2;
            this.lblListaArticulos.Text = "Lista Artículos";
            // 
            // cboCampo
            // 
            this.cboCampo.BackColor = System.Drawing.Color.Transparent;
            this.cboCampo.BorderRadius = 11;
            this.cboCampo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCampo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCampo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCampo.ItemHeight = 30;
            this.cboCampo.Location = new System.Drawing.Point(44, 242);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(140, 36);
            this.cboCampo.TabIndex = 3;
            this.cboCampo.DropDown += new System.EventHandler(this.cboCampo_DropDown);
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.BackColor = System.Drawing.Color.Transparent;
            this.cboCriterio.BorderRadius = 11;
            this.cboCriterio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCriterio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCriterio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCriterio.ItemHeight = 30;
            this.cboCriterio.Location = new System.Drawing.Point(208, 242);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(140, 36);
            this.cboCriterio.TabIndex = 4;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BorderRadius = 11;
            this.txtFiltroAvanzado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroAvanzado.DefaultText = "";
            this.txtFiltroAvanzado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltroAvanzado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltroAvanzado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroAvanzado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroAvanzado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroAvanzado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroAvanzado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(372, 242);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.PasswordChar = '\0';
            this.txtFiltroAvanzado.PlaceholderText = "";
            this.txtFiltroAvanzado.SelectedText = "";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroAvanzado.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BorderRadius = 11;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(596, 263);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BorderRadius = 11;
            this.btnOrdenar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdenar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdenar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrdenar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(596, 326);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(153, 36);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // cboOrdenCampo
            // 
            this.cboOrdenCampo.BackColor = System.Drawing.Color.Transparent;
            this.cboOrdenCampo.BorderRadius = 11;
            this.cboOrdenCampo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOrdenCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenCampo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboOrdenCampo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboOrdenCampo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboOrdenCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboOrdenCampo.ItemHeight = 30;
            this.cboOrdenCampo.Location = new System.Drawing.Point(44, 326);
            this.cboOrdenCampo.Name = "cboOrdenCampo";
            this.cboOrdenCampo.Size = new System.Drawing.Size(140, 36);
            this.cboOrdenCampo.TabIndex = 8;
            // 
            // cboOrdenCriterio
            // 
            this.cboOrdenCriterio.BackColor = System.Drawing.Color.Transparent;
            this.cboOrdenCriterio.BorderRadius = 11;
            this.cboOrdenCriterio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOrdenCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenCriterio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboOrdenCriterio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboOrdenCriterio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboOrdenCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboOrdenCriterio.ItemHeight = 30;
            this.cboOrdenCriterio.Location = new System.Drawing.Point(208, 326);
            this.cboOrdenCriterio.Name = "cboOrdenCriterio";
            this.cboOrdenCriterio.Size = new System.Drawing.Size(140, 36);
            this.cboOrdenCriterio.TabIndex = 9;
            // 
            // gpbModificarPrecios
            // 
            this.gpbModificarPrecios.Controls.Add(this.txtInformeModificacion);
            this.gpbModificarPrecios.Controls.Add(this.btnConfirmar);
            this.gpbModificarPrecios.Controls.Add(this.dgvPreciosModificar);
            this.gpbModificarPrecios.Controls.Add(this.btnAplicar);
            this.gpbModificarPrecios.Controls.Add(this.ckbValor);
            this.gpbModificarPrecios.Controls.Add(this.ckbPorcentaje);
            this.gpbModificarPrecios.Controls.Add(this.txtValorPrecio);
            this.gpbModificarPrecios.Controls.Add(this.cboPrecioCategorias);
            this.gpbModificarPrecios.Controls.Add(this.cboPrecioMarcas);
            this.gpbModificarPrecios.Controls.Add(this.ckbMarcas);
            this.gpbModificarPrecios.Controls.Add(this.ckbCategorias);
            this.gpbModificarPrecios.Controls.Add(this.rdbBajarPrecio);
            this.gpbModificarPrecios.Controls.Add(this.rdbSubirPrecio);
            this.gpbModificarPrecios.Location = new System.Drawing.Point(44, 402);
            this.gpbModificarPrecios.Name = "gpbModificarPrecios";
            this.gpbModificarPrecios.Size = new System.Drawing.Size(885, 257);
            this.gpbModificarPrecios.TabIndex = 12;
            this.gpbModificarPrecios.TabStop = false;
            this.gpbModificarPrecios.Text = "Modificar Precios:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BorderRadius = 11;
            this.btnConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(638, 214);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(189, 36);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Confirmar Modificación";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvPreciosModificar
            // 
            this.dgvPreciosModificar.AllowUserToResizeColumns = false;
            this.dgvPreciosModificar.AllowUserToResizeRows = false;
            this.dgvPreciosModificar.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvPreciosModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreciosModificar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvPreciosModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPreciosModificar.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvPreciosModificar.EnableHeadersVisualStyles = false;
            this.dgvPreciosModificar.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPreciosModificar.Location = new System.Drawing.Point(249, 33);
            this.dgvPreciosModificar.MultiSelect = false;
            this.dgvPreciosModificar.Name = "dgvPreciosModificar";
            this.dgvPreciosModificar.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreciosModificar.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvPreciosModificar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPreciosModificar.Size = new System.Drawing.Size(618, 164);
            this.dgvPreciosModificar.TabIndex = 16;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BorderRadius = 11;
            this.btnAplicar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAplicar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAplicar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAplicar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.Location = new System.Drawing.Point(29, 214);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(189, 36);
            this.btnAplicar.TabIndex = 15;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // ckbValor
            // 
            this.ckbValor.AutoSize = true;
            this.ckbValor.Location = new System.Drawing.Point(16, 180);
            this.ckbValor.Name = "ckbValor";
            this.ckbValor.Size = new System.Drawing.Size(50, 17);
            this.ckbValor.TabIndex = 14;
            this.ckbValor.Text = "Valor";
            this.ckbValor.UseVisualStyleBackColor = true;
            this.ckbValor.CheckedChanged += new System.EventHandler(this.ckbValor_CheckedChanged_1);
            // 
            // ckbPorcentaje
            // 
            this.ckbPorcentaje.AutoSize = true;
            this.ckbPorcentaje.Location = new System.Drawing.Point(16, 157);
            this.ckbPorcentaje.Name = "ckbPorcentaje";
            this.ckbPorcentaje.Size = new System.Drawing.Size(77, 17);
            this.ckbPorcentaje.TabIndex = 13;
            this.ckbPorcentaje.Text = "Porcentaje";
            this.ckbPorcentaje.UseVisualStyleBackColor = true;
            this.ckbPorcentaje.CheckedChanged += new System.EventHandler(this.ckbPorcentaje_CheckedChanged);
            // 
            // txtValorPrecio
            // 
            this.txtValorPrecio.BorderRadius = 11;
            this.txtValorPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorPrecio.DefaultText = "";
            this.txtValorPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValorPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValorPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValorPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorPrecio.Location = new System.Drawing.Point(99, 157);
            this.txtValorPrecio.MaxLength = 10;
            this.txtValorPrecio.Name = "txtValorPrecio";
            this.txtValorPrecio.PasswordChar = '\0';
            this.txtValorPrecio.PlaceholderText = "";
            this.txtValorPrecio.SelectedText = "";
            this.txtValorPrecio.Size = new System.Drawing.Size(133, 40);
            this.txtValorPrecio.TabIndex = 12;
            this.txtValorPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPrecio_KeyPress);
            // 
            // cboPrecioCategorias
            // 
            this.cboPrecioCategorias.BackColor = System.Drawing.Color.Transparent;
            this.cboPrecioCategorias.BorderRadius = 11;
            this.cboPrecioCategorias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPrecioCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrecioCategorias.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPrecioCategorias.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPrecioCategorias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPrecioCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPrecioCategorias.ItemHeight = 30;
            this.cboPrecioCategorias.Location = new System.Drawing.Point(100, 102);
            this.cboPrecioCategorias.Name = "cboPrecioCategorias";
            this.cboPrecioCategorias.Size = new System.Drawing.Size(132, 36);
            this.cboPrecioCategorias.TabIndex = 11;
            // 
            // cboPrecioMarcas
            // 
            this.cboPrecioMarcas.BackColor = System.Drawing.Color.Transparent;
            this.cboPrecioMarcas.BorderRadius = 11;
            this.cboPrecioMarcas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPrecioMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrecioMarcas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPrecioMarcas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPrecioMarcas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPrecioMarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPrecioMarcas.ItemHeight = 30;
            this.cboPrecioMarcas.Location = new System.Drawing.Point(100, 56);
            this.cboPrecioMarcas.Name = "cboPrecioMarcas";
            this.cboPrecioMarcas.Size = new System.Drawing.Size(132, 36);
            this.cboPrecioMarcas.TabIndex = 10;
            // 
            // ckbMarcas
            // 
            this.ckbMarcas.AutoSize = true;
            this.ckbMarcas.Location = new System.Drawing.Point(16, 71);
            this.ckbMarcas.Name = "ckbMarcas";
            this.ckbMarcas.Size = new System.Drawing.Size(61, 17);
            this.ckbMarcas.TabIndex = 3;
            this.ckbMarcas.Text = "Marcas";
            this.ckbMarcas.UseVisualStyleBackColor = true;
            // 
            // ckbCategorias
            // 
            this.ckbCategorias.AutoSize = true;
            this.ckbCategorias.Location = new System.Drawing.Point(16, 112);
            this.ckbCategorias.Name = "ckbCategorias";
            this.ckbCategorias.Size = new System.Drawing.Size(78, 17);
            this.ckbCategorias.TabIndex = 2;
            this.ckbCategorias.Text = "Categorías";
            this.ckbCategorias.UseVisualStyleBackColor = true;
            // 
            // rdbBajarPrecio
            // 
            this.rdbBajarPrecio.AutoSize = true;
            this.rdbBajarPrecio.Location = new System.Drawing.Point(122, 33);
            this.rdbBajarPrecio.Name = "rdbBajarPrecio";
            this.rdbBajarPrecio.Size = new System.Drawing.Size(107, 17);
            this.rdbBajarPrecio.TabIndex = 1;
            this.rdbBajarPrecio.TabStop = true;
            this.rdbBajarPrecio.Text = "Descontar Precio";
            this.rdbBajarPrecio.UseVisualStyleBackColor = true;
            // 
            // rdbSubirPrecio
            // 
            this.rdbSubirPrecio.AutoSize = true;
            this.rdbSubirPrecio.Location = new System.Drawing.Point(16, 33);
            this.rdbSubirPrecio.Name = "rdbSubirPrecio";
            this.rdbSubirPrecio.Size = new System.Drawing.Size(103, 17);
            this.rdbSubirPrecio.TabIndex = 0;
            this.rdbSubirPrecio.TabStop = true;
            this.rdbSubirPrecio.Text = "Aumentar Precio";
            this.rdbSubirPrecio.UseVisualStyleBackColor = true;
            // 
            // ckbFiltro1
            // 
            this.ckbFiltro1.AutoSize = true;
            this.ckbFiltro1.Location = new System.Drawing.Point(23, 254);
            this.ckbFiltro1.Name = "ckbFiltro1";
            this.ckbFiltro1.Size = new System.Drawing.Size(15, 14);
            this.ckbFiltro1.TabIndex = 13;
            this.ckbFiltro1.UseVisualStyleBackColor = true;
            this.ckbFiltro1.CheckedChanged += new System.EventHandler(this.ckbFiltro1_CheckedChanged);
            // 
            // ckbFiltro2
            // 
            this.ckbFiltro2.AutoSize = true;
            this.ckbFiltro2.Location = new System.Drawing.Point(23, 294);
            this.ckbFiltro2.Name = "ckbFiltro2";
            this.ckbFiltro2.Size = new System.Drawing.Size(15, 14);
            this.ckbFiltro2.TabIndex = 14;
            this.ckbFiltro2.UseVisualStyleBackColor = true;
            this.ckbFiltro2.CheckedChanged += new System.EventHandler(this.ckbFiltro2_CheckedChanged);
            // 
            // txtFiltroAvanzado1
            // 
            this.txtFiltroAvanzado1.BorderRadius = 11;
            this.txtFiltroAvanzado1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroAvanzado1.DefaultText = "";
            this.txtFiltroAvanzado1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltroAvanzado1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltroAvanzado1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroAvanzado1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroAvanzado1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroAvanzado1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroAvanzado1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroAvanzado1.Location = new System.Drawing.Point(372, 284);
            this.txtFiltroAvanzado1.Name = "txtFiltroAvanzado1";
            this.txtFiltroAvanzado1.PasswordChar = '\0';
            this.txtFiltroAvanzado1.PlaceholderText = "";
            this.txtFiltroAvanzado1.SelectedText = "";
            this.txtFiltroAvanzado1.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroAvanzado1.TabIndex = 17;
            // 
            // cboCriterio1
            // 
            this.cboCriterio1.BackColor = System.Drawing.Color.Transparent;
            this.cboCriterio1.BorderRadius = 11;
            this.cboCriterio1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCriterio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCriterio1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCriterio1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCriterio1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCriterio1.ItemHeight = 30;
            this.cboCriterio1.Location = new System.Drawing.Point(208, 284);
            this.cboCriterio1.Name = "cboCriterio1";
            this.cboCriterio1.Size = new System.Drawing.Size(140, 36);
            this.cboCriterio1.TabIndex = 16;
            // 
            // cboCampo1
            // 
            this.cboCampo1.BackColor = System.Drawing.Color.Transparent;
            this.cboCampo1.BorderRadius = 11;
            this.cboCampo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCampo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCampo1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCampo1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCampo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCampo1.ItemHeight = 30;
            this.cboCampo1.Location = new System.Drawing.Point(44, 284);
            this.cboCampo1.Name = "cboCampo1";
            this.cboCampo1.Size = new System.Drawing.Size(140, 36);
            this.cboCampo1.TabIndex = 15;
            this.cboCampo1.DropDown += new System.EventHandler(this.cboCampo1_DropDown);
            this.cboCampo1.SelectedIndexChanged += new System.EventHandler(this.cboCampo1_SelectedIndexChanged);
            // 
            // btnReiniciarFiltro
            // 
            this.btnReiniciarFiltro.BorderRadius = 11;
            this.btnReiniciarFiltro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReiniciarFiltro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReiniciarFiltro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReiniciarFiltro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReiniciarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReiniciarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnReiniciarFiltro.Location = new System.Drawing.Point(758, 263);
            this.btnReiniciarFiltro.Name = "btnReiniciarFiltro";
            this.btnReiniciarFiltro.Size = new System.Drawing.Size(153, 36);
            this.btnReiniciarFiltro.TabIndex = 18;
            this.btnReiniciarFiltro.Text = "Reiniciar Filtro";
            this.btnReiniciarFiltro.Click += new System.EventHandler(this.btnReiniciarFiltro_Click);
            // 
            // txtInformeModificacion
            // 
            this.txtInformeModificacion.BorderRadius = 11;
            this.txtInformeModificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInformeModificacion.DefaultText = "";
            this.txtInformeModificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInformeModificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInformeModificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInformeModificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInformeModificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInformeModificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInformeModificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInformeModificacion.Location = new System.Drawing.Point(236, 215);
            this.txtInformeModificacion.Name = "txtInformeModificacion";
            this.txtInformeModificacion.PasswordChar = '\0';
            this.txtInformeModificacion.PlaceholderText = "";
            this.txtInformeModificacion.ReadOnly = true;
            this.txtInformeModificacion.SelectedText = "";
            this.txtInformeModificacion.Size = new System.Drawing.Size(384, 35);
            this.txtInformeModificacion.TabIndex = 18;
            this.txtInformeModificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAvanzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(941, 695);
            this.Controls.Add(this.btnReiniciarFiltro);
            this.Controls.Add(this.txtFiltroAvanzado1);
            this.Controls.Add(this.cboCriterio1);
            this.Controls.Add(this.cboCampo1);
            this.Controls.Add(this.ckbFiltro2);
            this.Controls.Add(this.ckbFiltro1);
            this.Controls.Add(this.gpbModificarPrecios);
            this.Controls.Add(this.cboOrdenCriterio);
            this.Controls.Add(this.cboOrdenCampo);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblListaArticulos);
            this.Controls.Add(this.dgvDatosAvanzados);
            this.Controls.Add(this.pbxAvanzado);
            this.Name = "frmAvanzado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Precios:";
            this.Load += new System.EventHandler(this.frmAvanzado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvanzado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAvanzados)).EndInit();
            this.gpbModificarPrecios.ResumeLayout(false);
            this.gpbModificarPrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbxAvanzado;
        private System.Windows.Forms.DataGridView dgvDatosAvanzados;
        private System.Windows.Forms.Label lblListaArticulos;
        private Guna.UI2.WinForms.Guna2ComboBox cboCampo;
        private Guna.UI2.WinForms.Guna2ComboBox cboCriterio;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroAvanzado;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnOrdenar;
        private Guna.UI2.WinForms.Guna2ComboBox cboOrdenCampo;
        private Guna.UI2.WinForms.Guna2ComboBox cboOrdenCriterio;
        private System.Windows.Forms.GroupBox gpbModificarPrecios;
        private System.Windows.Forms.RadioButton rdbBajarPrecio;
        private System.Windows.Forms.RadioButton rdbSubirPrecio;
        private System.Windows.Forms.CheckBox ckbMarcas;
        private System.Windows.Forms.CheckBox ckbCategorias;
        private Guna.UI2.WinForms.Guna2TextBox txtValorPrecio;
        private Guna.UI2.WinForms.Guna2ComboBox cboPrecioCategorias;
        private Guna.UI2.WinForms.Guna2ComboBox cboPrecioMarcas;
        private System.Windows.Forms.CheckBox ckbValor;
        private System.Windows.Forms.CheckBox ckbPorcentaje;
        private Guna.UI2.WinForms.Guna2Button btnAplicar;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvPreciosModificar;
        private System.Windows.Forms.CheckBox ckbFiltro1;
        private System.Windows.Forms.CheckBox ckbFiltro2;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroAvanzado1;
        private Guna.UI2.WinForms.Guna2ComboBox cboCriterio1;
        private Guna.UI2.WinForms.Guna2ComboBox cboCampo1;
        private Guna.UI2.WinForms.Guna2Button btnReiniciarFiltro;
        private Guna.UI2.WinForms.Guna2TextBox txtInformeModificacion;
    }
}