using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_Funktionen
{
    internal class MyMath
    {
        static internal int Calc_ggT(int a, int b)
        {
            int z;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        static internal int Calc_kgV(int a, int b)
        {
            return a * b / Calc_ggT(a, b);
        }

        static internal int ReadInt(string prompt)
        {
            int zahl;
            while (true)
            {
                Console.WriteLine(prompt);

                if (int.TryParse(Console.ReadLine(), out zahl) && zahl > 0)
                {
                    return zahl;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe! Bitte eine positive Zahl > 0 eingeben.");
                }
            }
        }
        static internal void ShowResult(string typ, int a, int b, int result)
        {
            Console.WriteLine($"{typ} von {a} und {b} ist {result}");
        }
        static internal int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Calc_ggT_r(b, a % b);
            }
        }
        static internal double CalcAverage(int[] zahlen)
        {
            int sum = 0;
            for (int i = 0; i < zahlen.Length; i++)
            {
                sum += zahlen[i];
            }
            return (double)sum / zahlen.Length;
        }
        static internal int FindMin(int[] zahlen)
        {
            int min = zahlen[0];
            for (int i = 1; i < zahlen.Length; i++)
            {
                if (zahlen[i] < min)
                {
                    min = zahlen[i];
                }
            }
            return min;
        }
        static internal int FindMax(int[] zahlen)
        {
            int max = zahlen[0];
            for (int i = 1; i < zahlen.Length; i++)
            {
                if (zahlen[i] > max)
                {
                    max = zahlen[i];
                }
            }
            return max;
        }
        static internal int[] ReadArray(int anzahl)
        {
            int[] zahlen = new int[anzahl];
            for (int i = 0; i < anzahl; i++)
            {
                zahlen[i] = ReadInt($"Bitte Zahl {i + 1} eingeben (>0):");
            }
            return zahlen;
        }
        static internal void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}