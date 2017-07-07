using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiosAviones
{
    abstract class Viajante:Persona
    {
        
        private int horasViajadas;

        public int HorasViajadas
        {
            get { return horasViajadas; }
            set { horasViajadas = value; }
        }

        private Vuelo vuelo;

        public Vuelo Vuelo
        {
            get { return vuelo; }
            set { vuelo = value; }
        }
        
        public Viajante(string name, string apellido, int dni)
            : base(name, apellido, dni)
        {

        }
        
        public abstract string getPremio();
        public virtual void Viajar(int hs)
        {
            this.HorasViajadas += hs;
        }
    }
}
