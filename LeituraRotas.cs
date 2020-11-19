using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace InterfaceRotas_AG
{
    static class LeituraRotas
    {
        public static List<int> Rota = new List<int>();

        internal static bool RealizarLeituraRota()
        {
            do
            {
                string sourcePath = @"C:\GitHub\TRB2-IA\TRB2-IA-Interface-Grafica\bin\Debug\result_rota.txt";
                string[] ConteudoRota = new string[30];
                try
                {
                    FileInfo fileInfo = new FileInfo(sourcePath);
                    bool mutexOwned = false;
                    Mutex mutex = null;

                    try
                    {
                        mutex = new Mutex(true, "teste", out mutexOwned);
                        if (!mutexOwned)
                            mutex.WaitOne();

                        ConteudoRota = File.ReadAllLines(sourcePath);
                    }
                    finally
                    {
                        mutex?.ReleaseMutex();
                        mutex?.Dispose();
                        mutex = null;
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Ocorreu um erro");
                    Console.WriteLine(e.Message);
                }
                if(String.Compare(ConteudoRota[0], "v") == 0 && String.Compare(ConteudoRota[0], "v") == 0)
                {
                    for (int i = 0; i < ConteudoRota.Length - 2; i++) Rota.Add(int.Parse(ConteudoRota[i + 1]));
                    return true;
                }
            } while (true);
        }
    }    
}

