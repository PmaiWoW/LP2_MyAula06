using System;
using System.IO;

namespace EscreverBin
{
    class Program
    {
        private string ficheiro;
        static void Main(string[] args)
        {
            Program p = new Program();

            p.WriteBinInFile();
        }
        private Program()
        {
            // Definir nome e localização do ficheiro onde guardar dados
            ficheiro = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "ex3_escreverBinario.txt");
        }

        private void WriteBinInFile()
        {
            string s = "Olá";
            int i = 10;
            float x = 4.69f;

            FileStream fs = new FileStream(ficheiro, FileMode.Create,
                FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(s);
            bw.Write(i);
            bw.Write(x);

            Console.WriteLine($"{s}\n{i}\n{x}");

            bw.Close();
        }
    }
}
