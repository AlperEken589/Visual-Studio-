using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnetaban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            diziler OnePiece = new diziler();
            OnePiece.isim = "One piece";
            OnePiece.yıl = 1999;
            OnePiece.Bilgigoster();


        }
    }
    class diziler
    {
        public string tur;
        public int sezon;
        public float ımdb;
        public int yıl;
        public string platform;
        public string isim;

        public void Bilgigoster()
        {
            Console.WriteLine($"{isim} adlı dizi {yıl}da yayımlanmaya başlamıştır.");

        }
    }


}
