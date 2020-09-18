using System;

namespace escuela
{
    class Escuela
    {
        public string nombre;
        public string dirección;
        public int foundation = 2012;
        public void timbrar() {
            // Todo
            Console.Write("Va a sonar");
            Console.Beep(2000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscualaxD = new Escuela();
            miEscualaxD.nombre = "Platzi Academy";
            miEscualaxD.timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
