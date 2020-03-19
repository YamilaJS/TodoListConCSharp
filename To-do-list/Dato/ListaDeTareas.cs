using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_list.Modelo;

namespace To_do_list.Dato
{
    public class ListaDeTareas
    {
        List<TareaModelo> lista = new List<TareaModelo>();

        //metodo que muestra todas las tareas
        public List<TareaModelo> mostrarLista()
        {
            return lista;
        }

        public List<TareaModelo> getList()
        {
            return this.lista;
        }

        //metodo que agregar una tarea
        public void agregarTarea(TareaModelo tarea)
        {
            lista.Add(tarea);
        }
       
        //metodo que elimina una tarea
       
        public void eliminarTarea(TareaModelo tarea)
        {
           lista.RemoveAll(tareaItem => tareaItem._Titulo == tarea._Titulo);
        }
        
    }
}
