namespace PryEstructuraDeDatos
{
    partial class frmArbolBinario
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
            this.lblListado = new System.Windows.Forms.Label();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cboElementoEliminado = new System.Windows.Forms.ComboBox();
            this.lblCodigoEliminadoTexto = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbNuevoelemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gbxAcendente = new System.Windows.Forms.GroupBox();
            this.gbxDesendente = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbElementoEliminado.SuspendLayout();
            this.gpbNuevoelemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(12, 303);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(157, 13);
            this.lblListado.TabIndex = 29;
            this.lblListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(15, 329);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(215, 173);
            this.lstCola.TabIndex = 27;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvDatos.Location = new System.Drawing.Point(246, 329);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(372, 173);
            this.dgvDatos.TabIndex = 26;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // gpbElementoEliminado
            // 
            this.gpbElementoEliminado.Controls.Add(this.cboElementoEliminado);
            this.gpbElementoEliminado.Controls.Add(this.lblCodigoEliminadoTexto);
            this.gpbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpbElementoEliminado.Location = new System.Drawing.Point(441, 3);
            this.gpbElementoEliminado.Name = "gpbElementoEliminado";
            this.gpbElementoEliminado.Size = new System.Drawing.Size(161, 156);
            this.gpbElementoEliminado.TabIndex = 25;
            this.gpbElementoEliminado.TabStop = false;
            this.gpbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cboElementoEliminado
            // 
            this.cboElementoEliminado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElementoEliminado.FormattingEnabled = true;
            this.cboElementoEliminado.Location = new System.Drawing.Point(47, 29);
            this.cboElementoEliminado.Name = "cboElementoEliminado";
            this.cboElementoEliminado.Size = new System.Drawing.Size(112, 21);
            this.cboElementoEliminado.TabIndex = 6;
            // 
            // lblCodigoEliminadoTexto
            // 
            this.lblCodigoEliminadoTexto.AutoSize = true;
            this.lblCodigoEliminadoTexto.Location = new System.Drawing.Point(2, 33);
            this.lblCodigoEliminadoTexto.Name = "lblCodigoEliminadoTexto";
            this.lblCodigoEliminadoTexto.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminadoTexto.TabIndex = 5;
            this.lblCodigoEliminadoTexto.Text = "Codigo:";
            this.lblCodigoEliminadoTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(32, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 50);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gpbNuevoelemento
            // 
            this.gpbNuevoelemento.Controls.Add(this.txtTramite);
            this.gpbNuevoelemento.Controls.Add(this.txtNombre);
            this.gpbNuevoelemento.Controls.Add(this.txtCodigo);
            this.gpbNuevoelemento.Controls.Add(this.btnAgregar);
            this.gpbNuevoelemento.Controls.Add(this.lblTramite);
            this.gpbNuevoelemento.Controls.Add(this.lblNombre);
            this.gpbNuevoelemento.Controls.Add(this.lblCodigo);
            this.gpbNuevoelemento.Location = new System.Drawing.Point(246, 3);
            this.gpbNuevoelemento.Name = "gpbNuevoelemento";
            this.gpbNuevoelemento.Size = new System.Drawing.Size(178, 214);
            this.gpbNuevoelemento.TabIndex = 24;
            this.gpbNuevoelemento.TabStop = false;
            this.gpbNuevoelemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(56, 113);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(56, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 158);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 116);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(527, 508);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 36);
            this.btnAtras.TabIndex = 30;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(11, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(229, 214);
            this.treeView1.TabIndex = 31;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // gbxAcendente
            // 
            this.gbxAcendente.Location = new System.Drawing.Point(12, 232);
            this.gbxAcendente.Name = "gbxAcendente";
            this.gbxAcendente.Size = new System.Drawing.Size(284, 62);
            this.gbxAcendente.TabIndex = 32;
            this.gbxAcendente.TabStop = false;
            this.gbxAcendente.Text = "Acendente ";
            // 
            // gbxDesendente
            // 
            this.gbxDesendente.Location = new System.Drawing.Point(350, 232);
            this.gbxDesendente.Name = "gbxDesendente";
            this.gbxDesendente.Size = new System.Drawing.Size(252, 62);
            this.gbxDesendente.TabIndex = 33;
            this.gbxDesendente.TabStop = false;
            this.gbxDesendente.Text = "Desendente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(473, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 46);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(613, 552);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbxDesendente);
            this.Controls.Add(this.gbxAcendente);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gpbElementoEliminado);
            this.Controls.Add(this.gpbNuevoelemento);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpbElementoEliminado.ResumeLayout(false);
            this.gpbElementoEliminado.PerformLayout();
            this.gpbNuevoelemento.ResumeLayout(false);
            this.gpbNuevoelemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gpbElementoEliminado;
        private System.Windows.Forms.ComboBox cboElementoEliminado;
        private System.Windows.Forms.Label lblCodigoEliminadoTexto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gpbNuevoelemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox gbxAcendente;
        private System.Windows.Forms.GroupBox gbxDesendente;
        private System.Windows.Forms.Button btnBuscar;
    }
}