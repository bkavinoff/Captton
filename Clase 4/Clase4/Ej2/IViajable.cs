using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    interface IViajable
    {
        //metodos:
        int calcularPremio(int horasDeVuelo);
        float viajar(float horasDeVuelo);
    }
}
