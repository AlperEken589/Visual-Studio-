using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace kapsul
{
    class Ogrenci
    {
        int Numara;
        string Ad;
        string Soyad;
        int Vize;
        int Final;
        
        public Ogrenci(int numara, string ad, string soyad, int vize, int final)
        {
            this.numara = numara;
            Ad = ad;
            Soyad = soyad;
            this.vize = vize;
            this.final = final;
        }
        public Ogrenci()
        {
            numara = -1;
            ad = "GİRİLMEDİ";
            soyad = "GİRİLMEDİ";
            vize = -1;
            final = -1;
        }
        public string ad
        {
            get { return Ad; }
            set { Ad = value; }
        }
        public string soyad
        {
            get { return Soyad; }
            set { Soyad = value; }
        }
        public int numara
        {
            get { return this.Numara; }
            set { this.Numara = value; }

        }
        public int vize
        {
            get { return Vize; }
            set 
            {
                if (value == -1)
                {
                    vize = value;
                    Console.WriteLine("Öğrenci vizeye girmedi");
                }
                else if (value > 0)
                {
                    Vize = value;
                }
                else
                {
                    Console.WriteLine("Vize notu sıfırdan büyük olmalıdır");
                    vize = 0;
                }
            }
        }
        public int final
        {
            get { return Final; }
            set 
            {
                if (value == -1)
                {
                    Final = value;
                    Console.WriteLine("Öğrenci finale girmedi");
                }
                else if (value > 0)
                {
                    Final = value;
                }
                else
                {
                    Console.WriteLine("Vize notu sıfırdan büyük olmalıdır");
                    Final= 0;
                }
            }
        }
        public void Bilgigoster()
        {
            Console.WriteLine(ad+"/"+soyad+"/"+numara+"/"+vize+"/"+final);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Ogrenci ogrenci = new Ogrenci(2405, "Alper Erson", "EKEN", 40, 70);
                ogrenci.Bilgigoster();
                ogrenci.Vize = 1;
                ogrenci.Bilgigoster();
                ogrenci.Vize = 100;
                ogrenci.Bilgigoster();
                ogrenci.Vize = 60;
                ogrenci.Bilgigoster();
                ogrenci.Final = 1;
                ogrenci.Bilgigoster();
                ogrenci.Final = 100;
                ogrenci.Bilgigoster();
                ogrenci.Final = 70;
                ogrenci.Bilgigoster();
                Console.ReadKey();
            }
        }
    }
}
