using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbarino
{
    class Cliente
    {
        private string nombre;
        private int dni;

        public Cliente(string nombre, int dni)
        {

        }

        public void setDni(int dni)
        {
            this.dni = dni;
        }

        public int getDni()
        {
            return this.dni;
        }

        public string getNombre() {
            return this.nombre;
        }

        public void setNombre(string nombre) {

        }

        

    }
}
