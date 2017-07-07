using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    //abstract, es por que no se va a instanciar una persona.
    abstract class Persona
    {
        //el _ signidica que la variable es privada o protegida, es una convencion
        protected string _nombre, _apellido;
        protected int _dni;
        public Persona(string nombre, string apellido, int dni)
        {
            this._nombre = apellido;
            this._apellido = apellido;
            this._dni = dni;
        }

        //declaro los metodos que van a implementar todas las clases hijas de manera obligatoria
        public abstract void Hablar();
        public abstract string Comer();


        //virtual no es obligatorio que las hijas lo implementen
        public virtual string Pensar() {
            return "mmmm....";
        }
    }
}
