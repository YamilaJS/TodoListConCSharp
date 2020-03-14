using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_list.Modelo
{
    public class TareaModelo
    {
        public string _Titulo;
        public string _Descripcion;
        

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

      
        public TareaModelo(string Titulo, string Descripcion)
        {
            this.Titulo = Titulo;
            this.Descripcion = Descripcion;
        }
    }
}

