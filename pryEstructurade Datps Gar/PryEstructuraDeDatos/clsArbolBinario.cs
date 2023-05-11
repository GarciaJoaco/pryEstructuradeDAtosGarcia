using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEstructuraDeDatos
{
    class clsArbolBinario
    {
        private Nodo Inicio;

        public Nodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void Agregar(Nodo Nvo)
        {
            Nvo.izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                Nodo NodoPadre = Raiz;
                Nodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }

        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        

        public void InOrdenAsc(ListBox Lst, Nodo R)
        {
            if (R.izquierdo != null)
            {
                InOrdenAsc(Lst, R.izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }

        //----------------------------------------------------------------------------------

        //------- Recorrer InOrdenAsc StreamWriter --------
        public void RecorrerSW(StreamWriter sw)
        {
            InOrdenAsc(sw, Raiz);
        }

        public void InOrdenAsc(StreamWriter sw, Nodo R)
        {
            if (R.izquierdo != null) InOrdenAsc(sw, R.izquierdo);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.Derecho != null) InOrdenAsc(sw, R.Derecho);
        }

        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(ComboBox Combo, Nodo R)
        {
            if (R.izquierdo != null) InOrdenAsc(Combo, R.izquierdo);
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void InOrdenAsc(DataGridView Grilla, Nodo R)
        {
            if (R.izquierdo != null) InOrdenAsc(Grilla, R.izquierdo);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
        }
        public void RecorrerDeS(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenDes(lista, Raiz);
        }

        //-------- Recorrer InOrdenDesc ComboBox --------


        //------- Recorrer InOrdenDesc StreamWriter -------
        public void RecorrerDesSW(StreamWriter sw)
        {
            InOrdenDes(sw, Raiz);
        }

        public void InOrdenDes(StreamWriter sw, Nodo R)
        {
            if (R.Derecho != null) InOrdenDes(sw, R.Derecho);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.izquierdo != null) InOrdenDes(sw, R.izquierdo);
        }

        public void RecorrerDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);
        }

        public void InOrdenDes(ComboBox Combo, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
            if (R.izquierdo != null) InOrdenAsc(Combo, R.izquierdo);
        }


        //--------- Recorrer InOrdenDesc DataGridView --------
        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }

        public void InOrdenDes(DataGridView Grilla, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.izquierdo != null) InOrdenAsc(Grilla, R.izquierdo);
        }


        public void InOrdenDes(ListBox Lst, Nodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.izquierdo != null)
            {
                InOrdenAsc(Lst, R.izquierdo);
            }
        }
        //--------------------------------------------------------------------------------------------------
        //---------- Recorrer PreOrden StreamWriter --------
        public void RecorrerPreOrdenSW(StreamWriter sw)
        {
            PreOrden(sw, Raiz);
        }
        public void PreOrden(StreamWriter sw, Nodo R)
        {
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.izquierdo != null) InOrdenDes(sw, R.izquierdo);
            if (R.Derecho != null) InOrdenDes(sw, R.Derecho);
        }

        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }
        public void PreOrden(ListBox Lst, Nodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.izquierdo != null)
            {
                PreOrden(Lst, R.izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Lst, R.Derecho);
            }
        }
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void PreOrden(DataGridView Lst, Nodo R)
        {
            Lst.Rows.Add(R.Codigo, R.Nombre,R.Tramite);
            if (R.izquierdo != null)
            {
                PreOrden(Lst, R.izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Lst, R.Derecho);
            }
        }

        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }


        public void PreOrden(ComboBox Lst, Nodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.izquierdo != null)
            {
                PreOrden(Lst, R.izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Lst, R.Derecho);
            }
        }
        //-----------------------------------------------------------------------------------

        //---------- Recorrer PostOrden StreamWriter --------
        public void RecorrerPostOrdenSW(StreamWriter sw)
        {
            PostOrden(sw, Raiz);
        }
        public void PostOrden(StreamWriter sw, Nodo R)
        {
            if (R.izquierdo != null) InOrdenDes(sw, R.izquierdo);
            if (R.Derecho != null) InOrdenDes(sw, R.Derecho);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
        }
        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }
        //-------- Recorrer PostOrden ComboBox ---------
        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }

        public void PostOrden(ComboBox Combo, Nodo R)
        {
            if (R.izquierdo != null) InOrdenAsc(Combo, R.izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
        }


        //-------- Recorrer PostOrden DataGridView -------
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        public void PostOrden(DataGridView Grilla, Nodo R)
        {
            if (R.izquierdo != null) InOrdenAsc(Grilla, R.izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
        public void PostOrden(ListBox Lst, Nodo R)
        {
            if (R.izquierdo != null) PostOrden(Lst, R.izquierdo);
           
            if (R.Derecho != null) PostOrden(Lst, R.Derecho);
            
            Lst.Items.Add(R.Codigo);
        }

        private Nodo[] vector = new Nodo[100];
        private Int32 i = 0;
        //----------------------------------------------------------------------------------------------------
        public void Equilibrar()
        {
            i = 0;
            CargarVectorInOrden( Raiz);

            Raiz = null; EquilibrarArbo (0, i - 1);
             
        }
        private void CargarVectorInOrden( Nodo NodoPadre)
        {
            if (NodoPadre . izquierdo != null)
            {
                CargarVectorInOrden(NodoPadre.izquierdo);
            }
            vector[i] = NodoPadre;
            i = i + i;
            if (NodoPadre.Derecho !=null)
            {
                CargarVectorInOrden(NodoPadre.Derecho);

            }
        }
        private void EquilibrarArbo(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(vector[m]);
                EquilibrarArbo(ini, m - 1);
                EquilibrarArbo(m + 1, fin);
            }
        }
        public void Recorrer ( TreeView treeArbol)
        {
            treeArbol.Nodes.Clear();
           PreOrdenAsc(treeArbol.Nodes, Raiz);
        } 
        private void PreOrdenAsc ( TreeNodeCollection Nodopadre , Nodo R)
        {
            TreeNode NuevoNodo = Nodopadre.Add(R.Codigo.ToString());
            if (R.izquierdo != null) PreOrdenAsc(NuevoNodo.Nodes, R.izquierdo);
            if (R.Derecho != null) PreOrdenAsc(NuevoNodo.Nodes, R.Derecho);
        }

    }

}

