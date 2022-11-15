namespace PrySp3Repuestos_Cantallops
{
    partial class frmRepuestos
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.mrcIngresados = new System.Windows.Forms.GroupBox();
            this.ListBoxRepuestos = new System.Windows.Forms.ListBox();
            this.txtDescripcionConsulta = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.txtPrecioConsulta = new System.Windows.Forms.TextBox();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumeroConsulta = new System.Windows.Forms.TextBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.LstMarcaConsulta = new System.Windows.Forms.ComboBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.LstOrigen = new System.Windows.Forms.ComboBox();
            this.LstMarca = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.mrcIngresados.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(175, 382);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(99, 35);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(514, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 35);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(514, 67);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(99, 35);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // mrcIngresados
            // 
            this.mrcIngresados.Controls.Add(this.ListBoxRepuestos);
            this.mrcIngresados.Controls.Add(this.txtDescripcionConsulta);
            this.mrcIngresados.Controls.Add(this.lblDescripcion2);
            this.mrcIngresados.Controls.Add(this.txtPrecioConsulta);
            this.mrcIngresados.Controls.Add(this.lblPrecio2);
            this.mrcIngresados.Controls.Add(this.lblNumero2);
            this.mrcIngresados.Controls.Add(this.txtNumeroConsulta);
            this.mrcIngresados.Location = new System.Drawing.Point(12, 421);
            this.mrcIngresados.Name = "mrcIngresados";
            this.mrcIngresados.Size = new System.Drawing.Size(496, 181);
            this.mrcIngresados.TabIndex = 19;
            this.mrcIngresados.TabStop = false;
            this.mrcIngresados.Text = "Repuestos Ingresados";
            // 
            // ListBoxRepuestos
            // 
            this.ListBoxRepuestos.FormattingEnabled = true;
            this.ListBoxRepuestos.Location = new System.Drawing.Point(16, 41);
            this.ListBoxRepuestos.Name = "ListBoxRepuestos";
            this.ListBoxRepuestos.Size = new System.Drawing.Size(120, 95);
            this.ListBoxRepuestos.TabIndex = 23;
            // 
            // txtDescripcionConsulta
            // 
            this.txtDescripcionConsulta.Location = new System.Drawing.Point(269, 96);
            this.txtDescripcionConsulta.Name = "txtDescripcionConsulta";
            this.txtDescripcionConsulta.ReadOnly = true;
            this.txtDescripcionConsulta.Size = new System.Drawing.Size(170, 78);
            this.txtDescripcionConsulta.TabIndex = 14;
            this.txtDescripcionConsulta.Text = "";
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Location = new System.Drawing.Point(323, 80);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion2.TabIndex = 6;
            this.lblDescripcion2.Text = "Descripcion";
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.Location = new System.Drawing.Point(309, 47);
            this.txtPrecioConsulta.Multiline = true;
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.ReadOnly = true;
            this.txtPrecioConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioConsulta.TabIndex = 11;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(259, 50);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio2.TabIndex = 7;
            this.lblPrecio2.Text = "Precio";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(259, 16);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(44, 13);
            this.lblNumero2.TabIndex = 5;
            this.lblNumero2.Text = "Numero";
            // 
            // txtNumeroConsulta
            // 
            this.txtNumeroConsulta.Location = new System.Drawing.Point(309, 13);
            this.txtNumeroConsulta.Multiline = true;
            this.txtNumeroConsulta.Name = "txtNumeroConsulta";
            this.txtNumeroConsulta.ReadOnly = true;
            this.txtNumeroConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroConsulta.TabIndex = 13;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Location = new System.Drawing.Point(178, 299);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(96, 77);
            this.mrcOrigen.TabIndex = 4;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(10, 19);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 2;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(10, 42);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 3;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(148, 275);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(40, 13);
            this.lblMarca2.TabIndex = 1;
            this.lblMarca2.Text = "Marca ";
            // 
            // LstMarcaConsulta
            // 
            this.LstMarcaConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstMarcaConsulta.FormattingEnabled = true;
            this.LstMarcaConsulta.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.LstMarcaConsulta.Location = new System.Drawing.Point(194, 272);
            this.LstMarcaConsulta.Name = "LstMarcaConsulta";
            this.LstMarcaConsulta.Size = new System.Drawing.Size(121, 21);
            this.LstMarcaConsulta.TabIndex = 0;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.LstOrigen);
            this.mrcDatos.Controls.Add(this.LstMarca);
            this.mrcDatos.Controls.Add(this.txtDescripcion);
            this.mrcDatos.Controls.Add(this.lblMarca);
            this.mrcDatos.Controls.Add(this.txtPrecio);
            this.mrcDatos.Controls.Add(this.lblOrigen);
            this.mrcDatos.Controls.Add(this.txtNumero);
            this.mrcDatos.Controls.Add(this.lblNumero);
            this.mrcDatos.Controls.Add(this.lblDescripcion);
            this.mrcDatos.Controls.Add(this.lblPrecio);
            this.mrcDatos.Location = new System.Drawing.Point(12, 12);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(496, 204);
            this.mrcDatos.TabIndex = 18;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos del Repuesto";
            // 
            // LstOrigen
            // 
            this.LstOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstOrigen.FormattingEnabled = true;
            this.LstOrigen.Items.AddRange(new object[] {
            "N",
            "I"});
            this.LstOrigen.Location = new System.Drawing.Point(73, 55);
            this.LstOrigen.Name = "LstOrigen";
            this.LstOrigen.Size = new System.Drawing.Size(100, 21);
            this.LstOrigen.TabIndex = 14;
            // 
            // LstMarca
            // 
            this.LstMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstMarca.FormattingEnabled = true;
            this.LstMarca.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.LstMarca.Location = new System.Drawing.Point(73, 20);
            this.LstMarca.Name = "LstMarca";
            this.LstMarca.Size = new System.Drawing.Size(100, 21);
            this.LstMarca.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 101);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 78);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.Text = "";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(14, 23);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(326, 55);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(13, 58);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(326, 16);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(266, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(184, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(266, 58);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 614);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcOrigen);
            this.Controls.Add(this.mrcIngresados);
            this.Controls.Add(this.lblMarca2);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.LstMarcaConsulta);
            this.Name = "frmRepuestos";
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcIngresados.ResumeLayout(false);
            this.mrcIngresados.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox mrcIngresados;
        private System.Windows.Forms.RichTextBox txtDescripcionConsulta;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.TextBox txtPrecioConsulta;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.ComboBox LstMarcaConsulta;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumeroConsulta;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.ComboBox LstOrigen;
        private System.Windows.Forms.ComboBox LstMarca;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ListBox ListBoxRepuestos;
    }
}

