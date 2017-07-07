using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Empleado:Persona, ICobrador
    {
        //propiedades
        private float salarioHora;
        private float horasTrabajadas;

        //get-set
        public float getSalarioHora(){
            return this.salarioHora;
        }

        public void setHorasTrabajadas(float salario)
        {
            this.horasTrabajadas=salario;
        }

        public float getHorasTrabajadas()
        {
            return this.horasTrabajadas;
        }

        public void setSalarioHora(float salario)
        {
            this.salarioHora = salario;
        }

        public void emitirFactura()
        {

            Console.WriteLine("Factura Emitida por "+this._nombre+" "+this._apellido+" por un monto de $"+this.calcularMontoFacturar());
        }

        public float calcularMontoFacturar()
        {
            return this.getSalarioHora() * this.getHorasTrabajadas();
        }

        //constructor
        public Empleado(string nombre, string apellido, int dni, float salarioHora, float horasTrabajadas)
        :base(nombre, apellido, dni)
        {
            this.setSalarioHora(salarioHora);
            this.setHorasTrabajadas(horasTrabajadas);
        }
    }
}
