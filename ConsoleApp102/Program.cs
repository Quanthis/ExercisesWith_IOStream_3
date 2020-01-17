using System;
using System.IO;

namespace ConsoleApp102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program creates random numbers and saves them to file. ");
            string nazwa = @"c:\tmp\totolotek.txt";

            FileStream plik = new FileStream(nazwa, FileMode.Create, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);
            int [] tab = new int[6];
            Random r = new Random();
            for (int i=0; i<=5; i++)
            {
                tab[i] = r.Next(1, 49);
                Console.WriteLine(tab[i]);
                zapis.WriteLine(tab[i]);
            }
            zapis.Close();
            plik.Close();
            string b = @"c:\tmp\totolotek.txt";
            FileStream p = new FileStream(b, FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader z = new StreamReader(p);
            z.Close();
            p.Close();
            Console.ReadKey();
        }
    }
}
