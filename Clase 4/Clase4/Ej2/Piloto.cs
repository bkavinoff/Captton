﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Piloto : Persona
    {
        public Piloto(int dni, string nombre, string apellido, int edad, float horasDeVuelo)
        :base(dni, nombre, apellido, edad,horasDeVuelo)
        {

        }
        //public override void viajar(int cantHoras)
        //{
        //    base.viajar(cantHoras);

        //}
        //public override string Hablar(string mensaje)
        //{
        //    return "";//base.Hablar(mensaje);

        //}

    }
}
