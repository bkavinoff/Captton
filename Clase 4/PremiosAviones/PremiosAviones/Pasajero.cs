using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiosAviones
{
    class Pasajero:Viajante,Ifrases
    {
        //Todos van a tener un HOURS PRIZE se puede hacer en la clase padre?
        //deberia ser constante pero puede ser diferente para cada clase hija de viajante
        const int HOURS_PRIZE = 100;
        private bool isFreq;

        public bool IsFreq
        {
            get { return isFreq; }
            set { isFreq = value; }
        }
        

        public Pasajero(string name, string apellido, int dni)
            : base(name, apellido, dni)
        {

        }
        public override string getPremio()
        {
            return (this.HorasViajadas >= HOURS_PRIZE)
                ? this.isFreq
                ?"Felicitaciones usted ha llegado/superado las " + HOURS_PRIZE + " horas, y al ser frecuente se le regala un pasaje a Miami"
                : "Felicitaciones usted ha llegado/superado las " + HOURS_PRIZE + " horas, se le regala un pasaje a Brasil"
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

        public void decirFrase()
        {
            Console.WriteLine("Me trae una manta que me voy a dormir y tengo frio");
        }
        public override void Viajar(int hs)
        {
            base.Viajar(hs);
            decirFrase();

        }
    }
}
