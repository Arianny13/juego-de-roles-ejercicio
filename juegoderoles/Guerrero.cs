using Juegoderoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoderoles
{
    public class Guerrero : Personaje
    {
        // Propiedades específicas para el guerrero
        public int PuntosDeAtaque { get; set; }
               
        public Guerrero(string nombre, int nivel, int puntosDeVida, int puntosDeAtaque)
            : base(nombre, nivel, puntosDeVida)
        {
            PuntosDeAtaque = puntosDeAtaque;
        }

        // Método para el guerrero
        public void GritoDeGuerra()
        {
            Console.WriteLine("¡Por la gloria!");
        }
      
        public override void Atacar()
        {
            Console.WriteLine("El guerrero ataca con su espada!");
        }
    }
}
