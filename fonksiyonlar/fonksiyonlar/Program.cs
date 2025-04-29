// See https://aka.ms/new-console-template for more information

class program 
{
    static void Selamlama()
    {
        Console.WriteLine("merhaba");
    }
    static void Selamlama(string ad)
    {
        Console.WriteLine($"merhaba {ad}");
    }
    static void Selamlama(int yas)
    {
        Console.WriteLine($"yaşım {yas}");
    }
    static void Main(String[] args)
    {
        Selamlama();
        Selamlama("alper");
        Selamlama(20);
        int sonuc = Toplam(5, 15);
        Console.WriteLine(sonuc);
       // Console.WriteLine(sonuc); 2 kere yazsan bile aynı sonucu verir.

        //  Console.WriteLine($"sonuc1 : {Toplam(2.1f ,3)}");
        //    Console.WriteLine($"sonuc2 : {Toplam(4, 3.8f)}");
        //      Console.WriteLine($"sonuc3 : {Toplam(b:(int)3.8f , a: 9)}");
        //      Console.WriteLine($"sonuc4 : {Carpma(2, 3)}");
        //        Console.WriteLine($"sonuc5 : {Carpma(2)}");
        //Console.WriteLine($"sonuc6 : {Carpma(b = 2)}");  ( hata verir b = 2 yazarsan )
       // Console.WriteLine($"sonuc7 : {Bolme(2, 3)}");
        Console.WriteLine($"sonuc8 {Faktoryel(5)}");
        Console.WriteLine($"sonuc9 {Recfaktoryel(5)}");

    }
    static int Toplam(int a , int b)
    {
        return a + b;
        Console.WriteLine("int a int b");
    }
    static float Toplam( float a , int b)
    {
        return a + b;
        Console.WriteLine("float a int b");
    }
    static float Toplam( int a , float b)
    {
        return a + b;
        Console.WriteLine("int a float b");
    }
    static int Carpma(int a , int b = 1)
    {
        return a * b;
    }
    static float Bolme(int a = 1 , int b = 1)
    {
        return a / b;
    }
    static int Faktoryel(int y)
    {
        int sonuc = 1;
        for (int i = 1; i < y; i++)
        {
            sonuc *= i;
        }
        return sonuc;
    }
        static int Recfaktoryel(int y)
    {
        if (y == 1 || y == 0)
            return 1;
        else
        {
            return y * Recfaktoryel(y - 1);
        }
    }

}
