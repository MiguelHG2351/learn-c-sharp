using System;
using CoreEscuela;

namespace escuela_original
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012);
            escuela.pais = "Nicaragua";
            escuela.TipoDeEscuela = TiposDeEscuelas.Primaria;
            Console.WriteLine(escuela.año);
            Console.WriteLine(escuela.Nombre);
            Console.Write(escuela);
        }
    }
}
