namespace Presentacion
{
    partial class frmAgregar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.pbxArticuloAgregar = new System.Windows.Forms.PictureBox();
            this.btnAceptarAgregarArt = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelarAgregadoArt = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 77);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(88, 74);
            this.txtCodigo1.MaxLength = 3;
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo1.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 100);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(88, 126);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 129);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 155);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 181);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(88, 204);
            this.txtImagenUrl.MaxLength = 1000;
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(100, 20);
            this.txtImagenUrl.TabIndex = 11;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtImagenUrl_Leave);
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenUrl.Location = new System.Drawing.Point(12, 207);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(72, 13);
            this.lblImagenUrl.TabIndex = 10;
            this.lblImagenUrl.Text = "Imagen Url:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(88, 230);
            this.txtPrecio.MaxLength = 8;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 233);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(88, 152);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(100, 21);
            this.cboMarca.TabIndex = 14;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(89, 178);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(99, 21);
            this.cboCategoria.TabIndex = 15;
            // 
            // pbxArticuloAgregar
            // 
            this.pbxArticuloAgregar.Location = new System.Drawing.Point(212, 74);
            this.pbxArticuloAgregar.Name = "pbxArticuloAgregar";
            this.pbxArticuloAgregar.Size = new System.Drawing.Size(193, 176);
            this.pbxArticuloAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticuloAgregar.TabIndex = 18;
            this.pbxArticuloAgregar.TabStop = false;
            // 
            // btnAceptarAgregarArt
            // 
            this.btnAceptarAgregarArt.BorderRadius = 11;
            this.btnAceptarAgregarArt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptarAgregarArt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptarAgregarArt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptarAgregarArt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptarAgregarArt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAceptarAgregarArt.ForeColor = System.Drawing.Color.White;
            this.btnAceptarAgregarArt.Location = new System.Drawing.Point(94, 269);
            this.btnAceptarAgregarArt.Name = "btnAceptarAgregarArt";
            this.btnAceptarAgregarArt.Size = new System.Drawing.Size(134, 31);
            this.btnAceptarAgregarArt.TabIndex = 19;
            this.btnAceptarAgregarArt.Text = "Aceptar";
            this.btnAceptarAgregarArt.Click += new System.EventHandler(this.btnAceptarAgregarArt_Click);
            // 
            // btnCancelarAgregadoArt
            // 
            this.btnCancelarAgregadoArt.BorderRadius = 11;
            this.btnCancelarAgregadoArt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarAgregadoArt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarAgregadoArt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelarAgregadoArt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelarAgregadoArt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelarAgregadoArt.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAgregadoArt.Location = new System.Drawing.Point(245, 269);
            this.btnCancelarAgregadoArt.Name = "btnCancelarAgregadoArt";
            this.btnCancelarAgregadoArt.Size = new System.Drawing.Size(134, 31);
            this.btnCancelarAgregadoArt.TabIndex = 20;
            this.btnCancelarAgregadoArt.Text = "Cancelar";
            this.btnCancelarAgregadoArt.Click += new System.EventHandler(this.btnCancelarAgregadoArt_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(473, 324);
            this.Controls.Add(this.btnCancelarAgregadoArt);
            this.Controls.Add(this.btnAceptarAgregarArt);
            this.Controls.Add(this.pbxArticuloAgregar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo1);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.PictureBox pbxArticuloAgregar;
        private Guna.UI2.WinForms.Guna2Button btnAceptarAgregarArt;
        private Guna.UI2.WinForms.Guna2Button btnCancelarAgregadoArt;
    }
}