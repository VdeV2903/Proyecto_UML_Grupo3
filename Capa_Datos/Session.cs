using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Session
    {
        private int _id;
        private string  _nombre = "Marcos";
        private string  _apellidos = "Medina";
        private string  _carnet;

        private string nombreCompleto = "";
        public string getNombre()
        {
            nombreCompleto = _nombre + " " + _apellidos;
            return nombreCompleto;
        }


    }
}
