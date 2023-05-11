using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clslistasimple FilaDePersonas = new clslistasimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            FilaDePersonas.agregar(objNodo);
            FilaDePersonas.Recorrer(cbxcodigo);
            FilaDePersonas.Recorrer(dgvCola);
            FilaDePersonas.Recorrer(ltsCola);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            btnAgregar.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas != null)
            {
                Int32 X = Convert.ToInt32(cbxcodigo.Text);
                FilaDePersonas.ELIMINAR(X);
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(ltsCola);
                FilaDePersonas.Recorrer(cbxcodigo);
                cbxcodigo.Text = "";


            }
            else
            {
                MessageBox.Show("La lista esta vacia");

            }
            btnEliminar.Enabled = false;

        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;

        }
        private void validar()
        {
            if (txtCodigo.Text != string.Empty && txtNombre.Text != string.Empty && txtTramite.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            validar();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void btnEliminar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxcodigo.SelectedText==null)
            {
                btnEliminar.Enabled = false;

            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
