using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfaceRotas_AG
{
    static class LeituraRotas
    {
        public static int[] Rota = new int[30];

        internal static bool RealizarLeituraRota()
        {
            do
            {
                string sourcePath = @"C:\GitHub\engffn\InterfaceRotas\TestesRotas\rota2.txt";
                string[] ConteudoRota = new string[30];
                try
                {
                    FileInfo fileInfo = new FileInfo(sourcePath);
                    ConteudoRota = File.ReadAllLines(sourcePath);

                }
                catch (IOException e)
                {
                    Console.WriteLine("Ocorreu um erro");
                    Console.WriteLine(e.Message);
                }
                if(String.Compare(ConteudoRota[0], "v") == 0 && String.Compare(ConteudoRota[0], "v") == 0)
                {
                    for (int i = 0; i < ConteudoRota.Length - 2; i++) Rota[i] = int.Parse(ConteudoRota[i + 1]);
                    return true;
                }
            } while (true);
        }
    }    
}

