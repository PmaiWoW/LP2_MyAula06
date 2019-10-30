using System;
using System.IO;

namespace EscreverTexto
{
    class Program
    {
        private string ficheiro;

        static void Main(string[] args)
        {
            Program p = new Program();

            p.WriteInFile();
        }

        private Program()
        {
            // Definir nome e localização do ficheiro onde guardar dados
            ficheiro = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "ex3_escreverTexto.txt");
        }

        private void WriteInFile()
        {
            string s = "Olá";
            int i = 10;
            float x = 4.69f;

            using (StreamWriter sw = new StreamWriter(ficheiro))
            {
                sw.WriteLine(s);
                sw.WriteLine(i);
                sw.WriteLine(x);
            }
        }
    }
}
