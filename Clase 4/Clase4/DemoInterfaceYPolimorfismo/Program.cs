using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceYPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Animal");
            Tigre tigre = new Tigre("Tiger");
            Perro perro = new Perro("Dog");

            List<Animal> lista = new List<Animal>();

            lista.Add(animal);
            lista.Add(tigre);
            lista.Add(perro);

            foreach (Animal animalito in lista)
            {
                if (animalito is Perro)
                {
                    //el "as" castea, es lo mismo que hacer (Perro)animalito
                    Perro per = animalito as Perro;
                    Console.WriteLine(per.Pasear("el parque"));
                }
            }

            Console.ReadKey();
        }
    }
}
