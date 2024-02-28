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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvanzado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAvanzados)).BeginInit();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosAvanzados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosAvanzados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosAvanzados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatosAvanzados.EnableHeadersVisualStyles = false;
            this.dgvDatosAvanzados.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDatosAvanzados.Location = new System.Drawing.Point(12, 39);
            this.dgvDatosAvanzados.MultiSelect = false;
            this.dgvDatosAvanzados.Name = "dgvDatosAvanzados";
            this.dgvDatosAvanzados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosAvanzados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.btnBuscar.Location = new System.Drawing.Point(596, 242);
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
            this.btnOrdenar.Location = new System.Drawing.Point(596, 284);
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
            this.cboOrdenCampo.Location = new System.Drawing.Point(44, 284);
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
            this.cboOrdenCriterio.Location = new System.Drawing.Point(208, 284);
            this.cboOrdenCriterio.Name = "cboOrdenCriterio";
            this.cboOrdenCriterio.Size = new System.Drawing.Size(140, 36);
            this.cboOrdenCriterio.TabIndex = 9;
            // 
            // frmAvanzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(941, 454);
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
            this.Load += new System.EventHandler(this.frmAvanzado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvanzado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAvanzados)).EndInit();
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
    }
}