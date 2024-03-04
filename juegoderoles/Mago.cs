using juegoderoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Juegoderoles
{
    public class Mago : Personaje
    {
        // Propiedades
        public int PuntosDeMagia { get; set; }

        // Constructor
        public Mago(string nombre, int nivel, int puntosDeVida, int puntosDeMagia)
            : base(nombre, nivel, puntosDeVida)
        {
            PuntosDeMagia = puntosDeMagia;
        }
       
        public void LanzarHechizo()
        {
            Console.WriteLine("¡Aparece una bola de fuego!");
        }

       
        public override void Atacar()
        {
            Console.WriteLine("El mago lanza un rayo de energía!");
        }
    }

}
