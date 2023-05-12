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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.grpTipoDeOrden = new System.Windows.Forms.GroupBox();
            this.btnPostOrden = new System.Windows.Forms.RadioButton();
            this.btnPreOrden = new System.Windows.Forms.RadioButton();
            this.btnInOrden = new System.Windows.Forms.RadioButton();
            this.GrpListarDatos = new System.Windows.Forms.GroupBox();
            this.btnDescendente = new System.Windows.Forms.RadioButton();
            this.btnAscendente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbElementoEliminado.SuspendLayout();
            this.gpbNuevoelemento.SuspendLayout();
            this.grpTipoDeOrden.SuspendLayout();
            this.GrpListarDatos.SuspendLayout();
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
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
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
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(11, 12);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(229, 214);
            this.tvArbol.TabIndex = 31;
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // grpTipoDeOrden
            // 
            this.grpTipoDeOrden.Controls.Add(this.btnPostOrden);
            this.grpTipoDeOrden.Controls.Add(this.btnPreOrden);
            this.grpTipoDeOrden.Controls.Add(this.btnInOrden);
            this.grpTipoDeOrden.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoDeOrden.Location = new System.Drawing.Point(39, 246);
            this.grpTipoDeOrden.Margin = new System.Windows.Forms.Padding(2);
            this.grpTipoDeOrden.Name = "grpTipoDeOrden";
            this.grpTipoDeOrden.Padding = new System.Windows.Forms.Padding(2);
            this.grpTipoDeOrden.Size = new System.Drawing.Size(285, 53);
            this.grpTipoDeOrden.TabIndex = 35;
            this.grpTipoDeOrden.TabStop = false;
            this.grpTipoDeOrden.Text = "Tipo de Orden";
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.AutoSize = true;
            this.btnPostOrden.Location = new System.Drawing.Point(184, 19);
            this.btnPostOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(87, 20);
            this.btnPostOrden.TabIndex = 1;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.AutoSize = true;
            this.btnPreOrden.Location = new System.Drawing.Point(90, 19);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(80, 20);
            this.btnPreOrden.TabIndex = 1;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            // 
            // btnInOrden
            // 
            this.btnInOrden.AutoSize = true;
            this.btnInOrden.Location = new System.Drawing.Point(7, 19);
            this.btnInOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(70, 20);
            this.btnInOrden.TabIndex = 0;
            this.btnInOrden.Text = "InOrden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            // 
            // GrpListarDatos
            // 
            this.GrpListarDatos.Controls.Add(this.btnDescendente);
            this.GrpListarDatos.Controls.Add(this.btnAscendente);
            this.GrpListarDatos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpListarDatos.Location = new System.Drawing.Point(350, 231);
            this.GrpListarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.GrpListarDatos.Name = "GrpListarDatos";
            this.GrpListarDatos.Padding = new System.Windows.Forms.Padding(2);
            this.GrpListarDatos.Size = new System.Drawing.Size(268, 68);
            this.GrpListarDatos.TabIndex = 36;
            this.GrpListarDatos.TabStop = false;
            this.GrpListarDatos.Text = "Listar Datos";
            // 
            // btnDescendente
            // 
            this.btnDescendente.AutoSize = true;
            this.btnDescendente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescendente.Location = new System.Drawing.Point(141, 24);
            this.btnDescendente.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(101, 20);
            this.btnDescendente.TabIndex = 2;
            this.btnDescendente.TabStop = true;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = true;
            // 
            // btnAscendente
            // 
            this.btnAscendente.AutoSize = true;
            this.btnAscendente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscendente.Location = new System.Drawing.Point(12, 24);
            this.btnAscendente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(94, 20);
            this.btnAscendente.TabIndex = 1;
            this.btnAscendente.TabStop = true;
            this.btnAscendente.Text = "Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(633, 552);
            this.Controls.Add(this.GrpListarDatos);
            this.Controls.Add(this.grpTipoDeOrden);
            this.Controls.Add(this.tvArbol);
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
            this.grpTipoDeOrden.ResumeLayout(false);
            this.grpTipoDeOrden.PerformLayout();
            this.GrpListarDatos.ResumeLayout(false);
            this.GrpListarDatos.PerformLayout();
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
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.GroupBox grpTipoDeOrden;
        private System.Windows.Forms.RadioButton btnPostOrden;
        private System.Windows.Forms.RadioButton btnPreOrden;
        private System.Windows.Forms.RadioButton btnInOrden;
        private System.Windows.Forms.GroupBox GrpListarDatos;
        private System.Windows.Forms.RadioButton btnDescendente;
        private System.Windows.Forms.RadioButton btnAscendente;
    }
}