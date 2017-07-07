using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbarino
{
    class Producto
    {

        private string nombre;
        private int ean;
        float precio;
        public Producto(string nombre, int ean, float precio) {
            this.setNombre(nombre);
            this.setEan(ean);
            this.setPrecio(precio);
        }
        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setEan(int ean)
        {
            this.ean = ean;
        }
        public int getEan()
        {
            return this.ean;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }
        public float getPrecio()
        {
            return this.precio;
        }


    }
}
