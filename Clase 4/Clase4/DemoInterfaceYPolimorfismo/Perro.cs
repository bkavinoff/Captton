using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceYPolimorfismo
{
    class Perro:Animal, IPaseable
    {
        public Perro(string nombre)
        :base(nombre){
            
        }

        public string Pasear(string lugar)
        {
            return this._nombre + ": Estoy paseando por "+lugar;
        }
    }
}
