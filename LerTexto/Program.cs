using System;
using System.IO;

namespace LerTexto
{
    class Program
    {
        private string ficheiro;
        static void Main(string[] args)
        {
            Program p = new Program();

            p.ReadInFile();
        }
        private Program()
        {
            // Definir nome e localização do ficheiro onde guardar dados
            ficheiro = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "ex3_escreverTexto.txt");
        }

        private void ReadInFile()
        {
            string s;
            int i;
            float x;

            StreamReader sr = new StreamReader(ficheiro);

            s = sr.ReadLine();
            i = int.Parse(sr.ReadLine());
            float.TryParse(sr.ReadLine(), out x);

            Console.WriteLine($"{s}\n{i}\n{x}");

            sr.Close();
        }
    }
}
