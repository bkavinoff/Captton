using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    abstract class Persona//:IViajable
    {
        //atributos
        protected int _dni, _edad;
        protected string _nombre, _apellido;
        protected float _horasDeVuelo;

        //constructor
        public Persona(int dni,string nombre,string apellido,int edad, float horasDeVuelo) {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._horasDeVuelo = horasDeVuelo;
        }

        //metodos abstractos que van a heredar los hijos
        
    }
}
