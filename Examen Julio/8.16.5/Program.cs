using System;
using System.IO;

namespace _8._16._5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader ficheroOriginal = new StreamReader("documentoOriginal.txt");
            StreamWriter ficheroFinal = new StreamWriter("documentoFinal.txt");
            string linea;
            do
            {
                linea = ficheroOriginal.ReadLine();
                if (linea != null)
                {
                    linea = linea.Replace("Console.WriteLine", "printf");
                    linea = linea.Replace("Main", "main");
                    linea = linea.Replace("string", "char[80]");
                    linea = linea.Replace("static", "");
                    linea = linea.Replace("public", "");
                    if (!linea.StartsWith("using"))
                        ficheroFinal.WriteLine(linea);
                }
            } while (linea != null);
            ficheroOriginal.Close();
            ficheroFinal.Close();
            Console.ReadLine();
        }
    }
}
