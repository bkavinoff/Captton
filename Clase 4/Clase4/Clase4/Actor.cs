using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    class Actor : Persona
    {
        public Actor(string nombre, string apellido, int dni)
            : base(nombre, apellido, dni)
        {

        }

        public override void Hablar()
        {
            Console.WriteLine(this._nombre + " dice Soy Actor...");
        }

        public override string Comer()
        {
            return this._nombre + " no comparte.";
        }
    }
}
