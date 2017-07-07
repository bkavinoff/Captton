using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiosAviones
{
    class Piloto:Viajante,Ifrases
    {
        //Todos van a tener un HOURS PRIZE se puede hacer en la clase padre?
        //deberia ser constante pero puede ser diferente para cada clase hija de viajante
        const int HOURS_PRIZE=30;
        private string p1;
        private string p2;
        private int p3;

        public Piloto(string name, string apellido, int dni)
            : base(name, apellido, dni)
        {

        }

        public override void Hablar()
        {
            //Como consulto si estoy adentro de un vuelo
            throw new NotImplementedException();
        }

        public override string Comer()
        {
            throw new NotImplementedException();
        }


        public override string getPremio()
        {
            return (this.HorasViajadas >= HOURS_PRIZE) ? "Felicitaciones usted ha llegado/superado las "
                +HOURS_PRIZE+" horas, tiene una semana de descanso" :
                "Aun te faltan " + (HOURS_PRIZE - this.HorasViajadas) + " cantidad de horas para el premio";
        }

        public void decirFrase()
        {
            if (!this.Vuelo.Despego)
            {
                this.Vuelo.Despego = true;
                Console.WriteLine("Tripulación lista para despegar");
            }
            else 
            {
                Console.WriteLine("Abróchense los cinturones, vamos a aterrizar");
            }
        }
        public override void Viajar(int hs)
        {
            base.Viajar(hs);
            decirFrase();

        }
    }
}
