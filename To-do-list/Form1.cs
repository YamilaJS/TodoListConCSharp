using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_do_list.Dato;
using To_do_list.Modelo;

namespace To_do_list
{
    public partial class Form1 : Form
    {
        ListaDeTareas dato = new ListaDeTareas();
        

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TareaModelo modelo = agregarTarea();
            this.mostrarLista(modelo._Titulo);
            crearNuevo();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearNuevo();
        }

        private TareaModelo agregarTarea()
        {
            TareaModelo modelo = new TareaModelo(txtTitulo.Text, txtDescripcion.Text);
            dato.agregarTarea(modelo);
            return modelo;
        }
        private void mostrarLista(string title)
        {
            cblLista.Items.Add(title);
        }
        private void crearNuevo()
        {
            Console.WriteLine("hOLA");
            txtTitulo.Clear();
            txtDescripcion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < cblLista.Items.Count; i++)
            {
                
                if (cblLista.GetItemChecked(i))
                {
                    this.dato.eliminarTarea(this.dato.getList()[i]);
                }
                
            }


            //////////// eSTO DEEBE ESTAR EN OTRA FUNCION
            cblLista.Items.Clear();
            for (int i = 0; i < this.dato.getList().Count; i++)
            {
                cblLista.Items.Add(this.dato.getList()[i]._Titulo);
            }
           
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }


        
        
    }
}
