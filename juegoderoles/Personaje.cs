using Juegoderoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoderoles
{
    public class Personaje
    {
        // Propiedades 
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int PuntosDeVida { get; set; }

        // Constructor
        public Personaje(string nombre, int nivel, int puntosDeVida)
        {
            Nombre = nombre;
            Nivel = nivel;
            PuntosDeVida = puntosDeVida;
        }
        
        public virtual void Atacar()
        {
            Console.WriteLine("El personaje ataca!");
        }
    }
}
