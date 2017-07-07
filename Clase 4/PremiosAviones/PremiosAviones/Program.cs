using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiosAviones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo un vuelo de 40hs
            Vuelo vuelo = new Vuelo(40);
            Azafata az1 = new Azafata("una", "azafata", 123456);
            Azafata az2 = new Azafata("dos", "azafata", 123456);
            Piloto pi1 = new Piloto("una", "Piloto", 123456);
            Piloto pi2 = new Piloto("dos", "Piloto", 123456);
            Pasajero pa1 = new Pasajero("una", "Pasajero", 123456);
            Pasajero pa2 = new Pasajero("dos", "Pasajero", 123456);
            vuelo.AgregarViajante(az1);
            vuelo.AgregarViajante(az2);
            vuelo.AgregarViajante(pi1);
            vuelo.AgregarViajante(pi2);
            vuelo.AgregarViajante(pa1);
            vuelo.AgregarViajante(pa2);
            vuelo.viajar();
            Console.ReadKey();




        }
    }
}
