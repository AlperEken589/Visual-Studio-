using System.Transactions;

Console.WriteLine("Hello, World!");

int sayi = 9;
Math.Pow(3, 5);
Console.WriteLine(Math.Pow(3, 5));
string ad = "alper" ;
ad.ToUpper();
Console.WriteLine(ad.ToUpper());
Console.WriteLine(ad == ad.ToUpper());
Console.WriteLine(ad.ToLower());
bool check = ad.ToUpper() == ad;
Console.WriteLine(check);
bool check2 = ad.ToLower() == ad && sayi > 9;
Console.WriteLine(check2);
bool check3 = ad.ToLower() == ad || sayi < 9;
Console.WriteLine(check3);
string inputt = Console.ReadLine();
Console.WriteLine(inputt);

/*string slm = Console.ReadLine();
Console.WriteLine();*/

/*int sayi1 = Convert.ToInt32(Console.ReadLine());
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sayi1 * sayi2);*/
int sayi1 = 0, sayi2 = 0;
try
{
     sayi1 = Convert.ToInt32(Console.ReadLine());
     sayi2 = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine(" Hata Ayıklama ");
}
Console.WriteLine(sayi1 * sayi2);
try
{
    sayi1 = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Hata Ayıklama");
}
try
{
    sayi2 = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Hata Ayıklama");
}
Console.WriteLine(sayi1 + sayi2);