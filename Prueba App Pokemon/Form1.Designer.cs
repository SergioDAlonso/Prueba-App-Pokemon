namespace Prueba_App_Pokemon
{
    partial class VtnPrinc
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
            this.Pbxprincipal = new System.Windows.Forms.PictureBox();
            this.dgvprincipal = new System.Windows.Forms.DataGridView();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttSalir = new System.Windows.Forms.Button();
            this.bttModificar = new System.Windows.Forms.Button();
            this.bttEliFi = new System.Windows.Forms.Button();
            this.bttEliLog = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.bttFiltro = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroavan = new System.Windows.Forms.Label();
            this.txtFiltroAvanz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbxprincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbxprincipal
            // 
            this.Pbxprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pbxprincipal.Location = new System.Drawing.Point(596, 57);
            this.Pbxprincipal.Name = "Pbxprincipal";
            this.Pbxprincipal.Size = new System.Drawing.Size(244, 244);
            this.Pbxprincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbxprincipal.TabIndex = 0;
            this.Pbxprincipal.TabStop = false;
            // 
            // dgvprincipal
            // 
            this.dgvprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvprincipal.Location = new System.Drawing.Point(12, 57);
            this.dgvprincipal.MultiSelect = false;
            this.dgvprincipal.Name = "dgvprincipal";
            this.dgvprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprincipal.Size = new System.Drawing.Size(578, 244);
            this.dgvprincipal.TabIndex = 1;
            this.dgvprincipal.SelectionChanged += new System.EventHandler(this.dgvprincipal_SelectionChanged);
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(12, 322);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttAgregar.TabIndex = 2;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttSalir
            // 
            this.bttSalir.Location = new System.Drawing.Point(765, 322);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(75, 23);
            this.bttSalir.TabIndex = 3;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = true;
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // bttModificar
            // 
            this.bttModificar.Location = new System.Drawing.Point(103, 322);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(75, 23);
            this.bttModificar.TabIndex = 4;
            this.bttModificar.Text = "Modificar";
            this.bttModificar.UseVisualStyleBackColor = true;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // bttEliFi
            // 
            this.bttEliFi.Location = new System.Drawing.Point(184, 322);
            this.bttEliFi.Name = "bttEliFi";
            this.bttEliFi.Size = new System.Drawing.Size(120, 23);
            this.bttEliFi.TabIndex = 5;
            this.bttEliFi.Text = "Eliminacion Fisica";
            this.bttEliFi.UseVisualStyleBackColor = true;
            this.bttEliFi.Click += new System.EventHandler(this.bttEliFi_Click);
            // 
            // bttEliLog
            // 
            this.bttEliLog.Location = new System.Drawing.Point(310, 322);
            this.bttEliLog.Name = "bttEliLog";
            this.bttEliLog.Size = new System.Drawing.Size(120, 23);
            this.bttEliLog.TabIndex = 6;
            this.bttEliLog.Text = "Eliminacion Logica";
            this.bttEliLog.UseVisualStyleBackColor = true;
            this.bttEliLog.Click += new System.EventHandler(this.bttEliLog_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 27);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(50, 24);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(188, 20);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // bttFiltro
            // 
            this.bttFiltro.Location = new System.Drawing.Point(544, 360);
            this.bttFiltro.Name = "bttFiltro";
            this.bttFiltro.Size = new System.Drawing.Size(75, 23);
            this.bttFiltro.TabIndex = 9;
            this.bttFiltro.Text = "Buscar";
            this.bttFiltro.UseVisualStyleBackColor = true;
            this.bttFiltro.Click += new System.EventHandler(this.bttFiltro_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(12, 363);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo:";
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(53, 360);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 21);
            this.cbxCampo.TabIndex = 11;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(181, 363);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(229, 360);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 13;
            // 
            // lblFiltroavan
            // 
            this.lblFiltroavan.AutoSize = true;
            this.lblFiltroavan.Location = new System.Drawing.Point(356, 363);
            this.lblFiltroavan.Name = "lblFiltroavan";
            this.lblFiltroavan.Size = new System.Drawing.Size(83, 13);
            this.lblFiltroavan.TabIndex = 14;
            this.lblFiltroavan.Text = "Filtro Avanzado:";
            // 
            // txtFiltroAvanz
            // 
            this.txtFiltroAvanz.Location = new System.Drawing.Point(438, 360);
            this.txtFiltroAvanz.Name = "txtFiltroAvanz";
            this.txtFiltroAvanz.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroAvanz.TabIndex = 15;
            // 
            // VtnPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 396);
            this.Controls.Add(this.txtFiltroAvanz);
            this.Controls.Add(this.lblFiltroavan);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.bttFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.bttEliLog);
            this.Controls.Add(this.bttEliFi);
            this.Controls.Add(this.bttModificar);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.dgvprincipal);
            this.Controls.Add(this.Pbxprincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VtnPrinc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.VtnPrinc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbxprincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbxprincipal;
        private System.Windows.Forms.DataGridView dgvprincipal;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttSalir;
        private System.Windows.Forms.Button bttModificar;
        private System.Windows.Forms.Button bttEliFi;
        private System.Windows.Forms.Button bttEliLog;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button bttFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblFiltroavan;
        private System.Windows.Forms.TextBox txtFiltroAvanz;
    }
}

