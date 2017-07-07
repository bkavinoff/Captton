using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiosAviones
{
    class Azafata:Viajante,Ifrases
    {

        public Azafata(string name, string apellido, int dni)
            : base(name, apellido, dni)
        {

        }
        //Todos van a tener un HOURS PRIZE se puede hacer en la clase padre?
        //deberia ser constante pero puede ser diferente para cada clase hija de viajante
        const int HOURS_PRIZE = 50;
        public override string getPremio()
        {
            return (this.HorasViajadas >= HOURS_PRIZE) 
                ? "Felicitaciones usted ha llegado/superado las "+HOURS_PRIZE+" horas, tiene un bonus del 20% de su sueldo" 
                : "Aun te faltan " + (HOURS_PRIZE - this.HorasViajadas) + " cantidad de horas para el premio";
        }

        public override void Hablar()
        {
            throw new NotImplementedException();
        }

        public override string Comer()
        {
            throw new NotImplementedException();
        }

        public override void Viajar(int hs)
        {
            base.Viajar(hs);
            decirFrase();          
            
        }

        public void decirFrase()
        {
            if (this.Vuelo.ComidaServida)
            {
                Console.WriteLine("Ya se ha servido la comida");
            }
            else {
                this.Vuelo.ComidaServida = true;
                Console.WriteLine("Pasta o pollo");
                }
        }
    }
}
