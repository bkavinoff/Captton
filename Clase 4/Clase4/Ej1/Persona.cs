using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    abstract class Persona
    {
        protected string _nombre, _apellido;
        protected int _dni;

        public Persona(string nombre, string apellido, int dni) {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
        
        }

    }
}
