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
        DataTable tabla;
        ListaDeTareas dato = new ListaDeTareas();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarTarea();
            Iniciar();
            crearNuevo();
            mostrarLista();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearNuevo();
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Titulo");
            tabla.Columns.Add("Descripción");
            grilla.DataSource = tabla;
        }
        private void agregarTarea()
        {
            TareaModelo modelo = new TareaModelo("","") 
            { 
                _Titulo = txtTitulo.Text,
                _Descripcion = txtDescripcion.Text
            };
            dato.agregarTarea(modelo);
            
        }
        private void mostrarLista()
        {
            
            foreach (var item in dato.mostrarLista())
            {
                DataRow fila = tabla.NewRow();
                fila["Titulo"] = item._Titulo;
                fila["Descripción"] = item._Descripcion;
                tabla.Rows.Add(fila);
            } 
        }
        private void crearNuevo()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
