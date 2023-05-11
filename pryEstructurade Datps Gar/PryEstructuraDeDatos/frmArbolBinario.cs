using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEstructuraDeDatos
{
    public partial class frmArbolBinario : Form
    {
        clsArbolBinario objArbolBinario = new clsArbolBinario();
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsArbolBinario.Raiz  != null)
            {
                Int32 x = Convert.ToInt32(cboElementoEliminado.Text);
                clsArbolBinario.Eliminar (x);
                clsArbolBinario.ListarGrillaAsc(dgvDatos);
                clsArbolBinario.ListarComboAsc(lstCola);
                clsArbolBinario.



            }
           
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            this.Close ();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
