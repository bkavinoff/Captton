using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiosAviones
{
    abstract class Persona 
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        
        public Persona(string name,string apellido, int dni)
        {
            this.Name = name;
            this.Apellido = apellido;
            this.Dni= dni;
        }
        public abstract void Hablar();

        public abstract string Comer();
        
        public virtual string Pensar()
        {
            return "termine de pensar";
        }
        ////NO se puede sobreescribir porque es sealed
        //public sealed void Vivir()
        //{
        //    Console.WriteLine("vivir");
        //}
    }
}
