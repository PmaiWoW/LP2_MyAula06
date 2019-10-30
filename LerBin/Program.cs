using System;
using System.IO;

namespace LerBin
{
    class Program
    {
        private string ficheiro;
        static void Main(string[] args)
        {
            Program p = new Program();

            p.ReadBinInFile();
        }
        private Program()
        {
            // Definir nome e localização do ficheiro onde guardar dados
            ficheiro = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "ex3_escreverBinario.txt");
        }

        private void ReadBinInFile()
        {
            string s;
            int i;
            float x;

            using (FileStream fs = new FileStream(ficheiro, FileMode.Open,
                FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    s = br.ReadString();
                    i = br.ReadInt32();
                    x = br.ReadSingle();

                    Console.WriteLine($"{s}\n{i}\n{x}");
                }
            }
        }
    }
}
