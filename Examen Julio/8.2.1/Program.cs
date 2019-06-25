using System;
using System.IO;

namespace _8._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero;
            fichero = File.OpenText("C: /Users/blitz/Desktop/Documentos/Universidad Europea/Tecnología de Servidores y Bases de Datos/Bases - de - Datos/Examen Julio/8.1.1/bin/Debug/registroDeUsuario.txt");
            string linea = fichero.ReadLine();
            Console.WriteLine(linea);
            Console.WriteLine(fichero.ReadLine());
            Console.WriteLine(fichero.ReadLine());
            fichero.Close();
            Console.ReadLine();
        }
    }
}
