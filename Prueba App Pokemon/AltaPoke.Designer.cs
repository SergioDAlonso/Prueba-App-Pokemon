namespace Prueba_App_Pokemon
{
    partial class frmAltaPoke
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.TxbNombre = new System.Windows.Forms.TextBox();
            this.TxbDescripcion = new System.Windows.Forms.TextBox();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDebi = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxDebilidad = new System.Windows.Forms.ComboBox();
            this.lblurlImagen = new System.Windows.Forms.Label();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.Pbxprincipal = new System.Windows.Forms.PictureBox();
            this.bttAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pbxprincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(28, 37);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 103);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(81, 34);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(121, 20);
            this.txbNumero.TabIndex = 0;
            // 
            // TxbNombre
            // 
            this.TxbNombre.Location = new System.Drawing.Point(81, 66);
            this.TxbNombre.Name = "TxbNombre";
            this.TxbNombre.Size = new System.Drawing.Size(121, 20);
            this.TxbNombre.TabIndex = 1;
            // 
            // TxbDescripcion
            // 
            this.TxbDescripcion.Location = new System.Drawing.Point(81, 100);
            this.TxbDescripcion.Name = "TxbDescripcion";
            this.TxbDescripcion.Size = new System.Drawing.Size(121, 20);
            this.TxbDescripcion.TabIndex = 2;
            // 
            // bttAceptar
            // 
            this.bttAceptar.Location = new System.Drawing.Point(52, 232);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttAceptar.TabIndex = 6;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(164, 232);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 7;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(44, 170);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDebi
            // 
            this.lblDebi.AutoSize = true;
            this.lblDebi.Location = new System.Drawing.Point(21, 204);
            this.lblDebi.Name = "lblDebi";
            this.lblDebi.Size = new System.Drawing.Size(54, 13);
            this.lblDebi.TabIndex = 9;
            this.lblDebi.Text = "Debilidad:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(81, 170);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 4;
            // 
            // cbxDebilidad
            // 
            this.cbxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDebilidad.FormattingEnabled = true;
            this.cbxDebilidad.Location = new System.Drawing.Point(81, 201);
            this.cbxDebilidad.Name = "cbxDebilidad";
            this.cbxDebilidad.Size = new System.Drawing.Size(121, 21);
            this.cbxDebilidad.TabIndex = 5;
            // 
            // lblurlImagen
            // 
            this.lblurlImagen.AutoSize = true;
            this.lblurlImagen.Location = new System.Drawing.Point(20, 135);
            this.lblurlImagen.Name = "lblurlImagen";
            this.lblurlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblurlImagen.TabIndex = 12;
            this.lblurlImagen.Text = "UrlImagen:";
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(81, 135);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.txbUrlImagen.TabIndex = 3;
            this.txbUrlImagen.Leave += new System.EventHandler(this.txbUrlImagen_Leave);
            // 
            // Pbxprincipal
            // 
            this.Pbxprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pbxprincipal.Location = new System.Drawing.Point(245, 34);
            this.Pbxprincipal.Name = "Pbxprincipal";
            this.Pbxprincipal.Size = new System.Drawing.Size(214, 220);
            this.Pbxprincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbxprincipal.TabIndex = 14;
            this.Pbxprincipal.TabStop = false;
            // 
            // bttAgregarImagen
            // 
            this.bttAgregarImagen.Location = new System.Drawing.Point(208, 135);
            this.bttAgregarImagen.Name = "bttAgregarImagen";
            this.bttAgregarImagen.Size = new System.Drawing.Size(31, 23);
            this.bttAgregarImagen.TabIndex = 15;
            this.bttAgregarImagen.Text = "+";
            this.bttAgregarImagen.UseVisualStyleBackColor = true;
            this.bttAgregarImagen.Click += new System.EventHandler(this.bttAgregarImagen_Click);
            // 
            // frmAltaPoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 266);
            this.Controls.Add(this.bttAgregarImagen);
            this.Controls.Add(this.Pbxprincipal);
            this.Controls.Add(this.txbUrlImagen);
            this.Controls.Add(this.lblurlImagen);
            this.Controls.Add(this.cbxDebilidad);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblDebi);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.TxbDescripcion);
            this.Controls.Add(this.TxbNombre);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumero);
            this.Name = "frmAltaPoke";
            this.Text = "AltaPoke";
            this.Load += new System.EventHandler(this.frmAltaPoke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbxprincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox TxbNombre;
        private System.Windows.Forms.TextBox TxbDescripcion;
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDebi;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxDebilidad;
        private System.Windows.Forms.Label lblurlImagen;
        private System.Windows.Forms.TextBox txbUrlImagen;
        internal System.Windows.Forms.PictureBox Pbxprincipal;
        private System.Windows.Forms.Button bttAgregarImagen;
    }
}