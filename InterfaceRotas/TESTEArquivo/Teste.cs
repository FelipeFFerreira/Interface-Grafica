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
        internal static void RealizarLeituraRota()
        {
            string sourcePath = @"C:\GitHub\engffn\InterfaceRotas\TestesRotas\rota1.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                string[] ConteudoRota = File.ReadAllLines(sourcePath);
                foreach (string line in ConteudoRota)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}

