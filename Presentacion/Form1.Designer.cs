namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblListadoArticulos = new System.Windows.Forms.Label();
            this.txtBuscarArticulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregarPrincipal = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificarPrincipal = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarPrincipal = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvanzadosPrincipal = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDatos.Location = new System.Drawing.Point(12, 44);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDatos.Size = new System.Drawing.Size(652, 348);
            this.dgvDatos.TabIndex = 0;
            // 
            // lblListadoArticulos
            // 
            this.lblListadoArticulos.AutoSize = true;
            this.lblListadoArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoArticulos.Location = new System.Drawing.Point(12, 19);
            this.lblListadoArticulos.Name = "lblListadoArticulos";
            this.lblListadoArticulos.Size = new System.Drawing.Size(123, 16);
            this.lblListadoArticulos.TabIndex = 21;
            this.lblListadoArticulos.Text = "Buscar Artículos:";
            // 
            // txtBuscarArticulo
            // 
            this.txtBuscarArticulo.BorderRadius = 11;
            this.txtBuscarArticulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarArticulo.DefaultText = "Ingrese nombre, marca o categoría";
            this.txtBuscarArticulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarArticulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarArticulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarArticulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarArticulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarArticulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarArticulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarArticulo.Location = new System.Drawing.Point(144, 12);
            this.txtBuscarArticulo.Name = "txtBuscarArticulo";
            this.txtBuscarArticulo.PasswordChar = '\0';
            this.txtBuscarArticulo.PlaceholderText = "Ingrese nombre, marca o categoría";
            this.txtBuscarArticulo.SelectedText = "";
            this.txtBuscarArticulo.Size = new System.Drawing.Size(205, 26);
            this.txtBuscarArticulo.TabIndex = 22;
            this.txtBuscarArticulo.TextChanged += new System.EventHandler(this.txtBuscarArticulo_TextChanged);
            this.txtBuscarArticulo.Enter += new System.EventHandler(this.txtBuscarArticulo_Enter);
            // 
            // btnAgregarPrincipal
            // 
            this.btnAgregarPrincipal.BorderRadius = 11;
            this.btnAgregarPrincipal.BorderThickness = 1;
            this.btnAgregarPrincipal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPrincipal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPrincipal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarPrincipal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPrincipal.Location = new System.Drawing.Point(73, 398);
            this.btnAgregarPrincipal.Name = "btnAgregarPrincipal";
            this.btnAgregarPrincipal.Size = new System.Drawing.Size(127, 31);
            this.btnAgregarPrincipal.TabIndex = 24;
            this.btnAgregarPrincipal.Text = "Agregar";
            this.btnAgregarPrincipal.Click += new System.EventHandler(this.btnAgregarPrincipal_Click);
            // 
            // btnModificarPrincipal
            // 
            this.btnModificarPrincipal.BorderRadius = 11;
            this.btnModificarPrincipal.BorderThickness = 1;
            this.btnModificarPrincipal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarPrincipal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarPrincipal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarPrincipal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificarPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrincipal.Location = new System.Drawing.Point(206, 398);
            this.btnModificarPrincipal.Name = "btnModificarPrincipal";
            this.btnModificarPrincipal.Size = new System.Drawing.Size(127, 31);
            this.btnModificarPrincipal.TabIndex = 25;
            this.btnModificarPrincipal.Text = "Modificar";
            this.btnModificarPrincipal.Click += new System.EventHandler(this.btnModificarPrincipal_Click);
            // 
            // btnEliminarPrincipal
            // 
            this.btnEliminarPrincipal.BorderRadius = 11;
            this.btnEliminarPrincipal.BorderThickness = 1;
            this.btnEliminarPrincipal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPrincipal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPrincipal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPrincipal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminarPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPrincipal.Location = new System.Drawing.Point(339, 398);
            this.btnEliminarPrincipal.Name = "btnEliminarPrincipal";
            this.btnEliminarPrincipal.Size = new System.Drawing.Size(127, 31);
            this.btnEliminarPrincipal.TabIndex = 26;
            this.btnEliminarPrincipal.Text = "Eliminar";
            this.btnEliminarPrincipal.Click += new System.EventHandler(this.btnEliminarPrincipal_Click);
            // 
            // btnAvanzadosPrincipal
            // 
            this.btnAvanzadosPrincipal.BorderRadius = 11;
            this.btnAvanzadosPrincipal.BorderThickness = 1;
            this.btnAvanzadosPrincipal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvanzadosPrincipal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvanzadosPrincipal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvanzadosPrincipal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvanzadosPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAvanzadosPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnAvanzadosPrincipal.Location = new System.Drawing.Point(472, 398);
            this.btnAvanzadosPrincipal.Name = "btnAvanzadosPrincipal";
            this.btnAvanzadosPrincipal.Size = new System.Drawing.Size(127, 31);
            this.btnAvanzadosPrincipal.TabIndex = 27;
            this.btnAvanzadosPrincipal.Text = "Filtros Avanzados";
            this.btnAvanzadosPrincipal.Click += new System.EventHandler(this.btnAvanzadosPrincipal_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(679, 467);
            this.Controls.Add(this.btnAvanzadosPrincipal);
            this.Controls.Add(this.btnEliminarPrincipal);
            this.Controls.Add(this.btnModificarPrincipal);
            this.Controls.Add(this.btnAgregarPrincipal);
            this.Controls.Add(this.txtBuscarArticulo);
            this.Controls.Add(this.lblListadoArticulos);
            this.Controls.Add(this.dgvDatos);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(695, 489);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblListadoArticulos;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarArticulo;
        private Guna.UI2.WinForms.Guna2Button btnAgregarPrincipal;
        private Guna.UI2.WinForms.Guna2Button btnModificarPrincipal;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPrincipal;
        private Guna.UI2.WinForms.Guna2Button btnAvanzadosPrincipal;
    }
}

