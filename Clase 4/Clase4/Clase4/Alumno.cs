using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    class Alumno : Persona
    {
        public float promedio;
        //con :base() llamo al constructor de la clase padre
        public Alumno(string nombre, string apellido, int dni, float promedio)
            : base(nombre, apellido, dni)
        {
            this.promedio = promedio;
        }

        public override void Hablar()
        {
            Console.WriteLine("Good morning!");
        }

        public override string Comer()
        {
            return "Acabo de comer";
        }

        public override string Pensar()
        {
            return "2 + 2 es 5";
        }

        public void AsistirAClases()
        {
            if (this.promedio >= 6)
            {
                Console.WriteLine(this._nombre + " es buen alumno.");
            }
            else
            {
                Console.WriteLine(this._nombre + " es mal alumno.");
            }
        }
    }
}
