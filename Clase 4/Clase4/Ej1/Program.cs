using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Juan", "Perez", 123, 50, 10);
            Empleado empleado2 = new Empleado("Jose", "Lopez", 123, 50, 10);
            Empleado empleado3 = new Empleado("Roman", "Arnaldo", 123, 50, 10);
            Empleado empleado4 = new Empleado("Etiope", "Pasaf", 123, 50, 10);

            empleado.emitirFactura();


            Console.ReadKey();
        }
    }
}
