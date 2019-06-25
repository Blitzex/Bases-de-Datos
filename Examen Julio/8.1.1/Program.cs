using System;
using System.IO;

namespace _8._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero = new StreamWriter("registroDeUsuario.txt");
            string frase;

            do
            {
                Console.Write("Introduce una frase en el fichero: ");
                frase = Console.ReadLine();
                if (frase != "fin")
                {
                    fichero.WriteLine(frase);
                }
            }
            while (frase != "fin");
            fichero.Close();
            Console.ReadLine();
        }
    }
}
