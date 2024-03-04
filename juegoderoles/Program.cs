using juegoderoles;
using Juegoderoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo12
{
    internal class Program
    {
        static void Main()
        {
            
            Guerrero miGuerrero = new Guerrero("Goku", 10, 100, 20);
            Console.WriteLine($"Nombre: {miGuerrero.Nombre}, Nivel: {miGuerrero.Nivel}");
            miGuerrero.Atacar(); 
            miGuerrero.GritoDeGuerra();

           
            Mago miMago = new Mago("Enock", 15, 80, 50);
            Console.WriteLine($"Nombre: {miMago.Nombre}, Nivel: {miMago.Nivel}");
            miMago.Atacar(); 
            miMago.LanzarHechizo();
        }
    }
}