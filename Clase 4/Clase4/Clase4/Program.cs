using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor actor = new Actor("Joey", "Tribbieni", 123123);
            Alumno alumno = new Alumno("Joffrey","Baratheon",321321, 2.5f);

            actor.Hablar();
            Console.WriteLine(actor.Comer());

            alumno.AsistirAClases();

            Console.ReadKey();



        }
    }
}
