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
    public partial class frmListaDoble : Form
    {
        clsListaDoble objListaDoble = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (objListaDoble.primero != null)
            {
                Int32 Eliminar = Convert.ToInt32(cboElementoEliminado.Text);
                objListaDoble.eliminar(Eliminar);
                objListaDoble.Recorrer(dgvDatos);
                objListaDoble.Recorrer(lstCola);
                objListaDoble.Recorrer(cboElementoEliminado);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objListaDoble.agregar (objNodo);
            objListaDoble.Recorrer(dgvDatos);
            objListaDoble.Recorrer(lstCola);
            objListaDoble.Recorrer(cboElementoEliminado);

            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtTramite.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
