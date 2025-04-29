using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Hayvan
    {
        public string tur;
        public string cins;
        public string renk;
        public int ayakSayısı;
        public Hayvan()
        {
            tur = "tür girilmedi";
            cins = "cins girilmedi";
            renk = "renk girilmedi";
            ayakSayısı = -1;
            Console.WriteLine("Default constructor çalıştı");

        }

        public Hayvan(string tur, string cins, string renk, int ayakSayısı)
        {
            this.tur = tur;
            this.cins = cins;
            this.renk = renk;
            this.ayakSayısı = ayakSayısı;
            Console.WriteLine("tüm değişkenlerin olduğu constructor çalıştı");

        }
        public Hayvan(string tur, int ayakSayısı)
        {
            this.tur = tur;
            this.ayakSayısı = ayakSayısı;
        }
    }
    class Urun
    {
        public string urunAdı;
        public int urunfıyat;
        public int urunStok;

        public Urun()
        {
            urunAdı = "ad girilmedi";
            urunfıyat = 1;
            urunStok = 1;
            Console.WriteLine("default constructor çalıştı");
        }
        public Urun(string urunAdı, int urunfıyat, int urunStok)
        {
            this.urunAdı = urunAdı;
            this.urunfıyat = urunfıyat;
            this.urunStok = urunStok;
            Console.WriteLine(urunAdı);
            Console.WriteLine(urunfıyat);
            Console.WriteLine(urunStok);

        }

    }
    class Personel
    {
        public string isim;
        public string soyİsim;
        public string departmanB;
        public Personel()
        {
            isim = "Alper Erson";
            soyİsim = "EKEN";
            departmanB = "GİRİLMEDİ";
        }
        public Personel(string isim, string soyİsim, string departmanB)
        {
            this.isim = isim;
            this.soyİsim = soyİsim;
            this.departmanB = departmanB;
            Console.WriteLine(isim);
            Console.WriteLine(soyİsim);
            Console.WriteLine(departmanB);
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            Hayvan h1 = new Hayvan();
            Console.WriteLine(h1.tur);
            h1.tur = "kedi";
            Console.WriteLine(h1.renk);
            h1.renk = "turuncu";
            Hayvan h2 = new Hayvan("köpek", "bulldog", "siyah", 5);
            Hayvan h3 = new Hayvan("kaplumbağa", 3);

            Urun U1 = new Urun();
            Console.WriteLine(U1.urunAdı);
            U1.urunAdı = "klavye";
            Urun U2 = new Urun("klavye", 500, 200);
            Personel P1 = new Personel();
            Console.WriteLine(P1.isim);
            P1.isim = "Alper Erson";
            Console.WriteLine(P1.soyİsim);
            P1.soyİsim = "EKEN";
            Console.WriteLine(P1.departmanB);
            P1.departmanB = "Girilemedi";
        }
    }
}

