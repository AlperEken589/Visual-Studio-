using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyon2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(($"Sonuç: {Ushesaplama(4, 3)} "));
           Fibonaci(10); 
        }

        static int Ushesaplama(int taban, int us)
        {
            int sonuc = 1;
            for(int i = 1; i <= us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }
        static int Usalma(int taban, int us)
        {
            if(us == 1)
            {
                return 1;
            }
            else if(us == 1)
            {
                return taban;
            }
            else 
            {
                return taban * Usalma(taban, us - 1);
            }
        }
        static void Fibonaci(int adım)
        {
            int bironceki = 1;
            int ikionceki = 0;
            for(int i = 2; i<= adım; i++)
            {
                Console.WriteLine($"{i} adım değeri: {bironceki + ikionceki} ");
                int gecici = bironceki;
                bironceki = bironceki + ikionceki;
                ikionceki = gecici;   
            }
        }

    }
}

