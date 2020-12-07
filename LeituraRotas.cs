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
        static private string DirArq = @"C:\GitHub\Interface-Grafica\bin\Debug\result_rota.txt";
        public static List<int> Rota = new List<int>();
        public static int PosInicio;
        public static int PosFinal;
        static private char[] charsToTrim = { 'i', 'f' };
        
        internal static bool RealizarLeituraRota()
        {
            do
            {
                string sourcePath = DirArq;
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
                if(String.Compare(ConteudoRota[0], "v") == 0 && String.Compare(ConteudoRota[ConteudoRota.Length - 1], "v") == 0)
                {
                    for (int i = 0; i < ConteudoRota.Length - 2; i++)
                    {
                        if (ConteudoRota[i + 1].Contains('i') || ConteudoRota[i + 1].Contains('f'))
                            if (ConteudoRota[i + 1].Contains('i'))
                            {
                                PosInicio = int.Parse(ConteudoRota[i + 1].Trim(charsToTrim));
                            }
                            else
                            {
                                PosFinal = int.Parse(ConteudoRota[i + 1].Trim(charsToTrim));
                            }

                        Rota.Add(int.Parse(ConteudoRota[i + 1].Trim(charsToTrim)));
                    }
                        
                    return true;
                }
            } while (true);
        }
    }    
}

