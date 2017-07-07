using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiosAviones
{
    class Vuelo
    {

        private int hs;

        public int Hs
        {
            get { return hs; }
            set { hs = value; }
        }
        

        private bool comidaServida;

        public bool ComidaServida
        {
            get { return comidaServida; }
            set { comidaServida = value; }
        }
        
        private bool despego;

        public bool Despego
        {
            get { return despego; }
            set { despego = value; }
        }
        
        private List<Viajante> listaViajantes;

        public List<Viajante> ListaViajantes
        {
            get { return listaViajantes; }
            set { listaViajantes = value; }
        }
        public Vuelo()
        {
            listaViajantes = new List<Viajante>();
            this.Despego = false;
            this.comidaServida = false;
        }

        public Vuelo(int hs)
        {
            listaViajantes = new List<Viajante>();
            this.Despego = false;
            this.Hs = hs;
        }


        public void viajar()
        {
            foreach (Viajante v in listaViajantes)
            {
                v.Viajar(this.Hs);
            }


        }

        public void AgregarViajante(Viajante v){
            v.Vuelo = this;
            this.ListaViajantes.Add(v);

        }


    }
}