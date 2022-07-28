using System.Net;

namespace odev;
class Program

{
    static void Main(string[] args)
    {

        int[] ana_koleksiyon = new int[5];
        int n = 0;

        System.Console.WriteLine(ana_koleksiyon.Count() + " Adet sayı giriniz");

        for (int i = 0; i < ana_koleksiyon.Count(); i++)
        {
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {

                ana_koleksiyon[i] = n;
            }
            else
            {
                Console.WriteLine("Geçerli Sayısal Değer Giriniz");
                i--;
            }
        }

        int[] koleksiyon = ana_koleksiyon;

        Array.Sort(ana_koleksiyon);
        Array.Resize(ref ana_koleksiyon, 3);

        Array.Sort(koleksiyon);
        Array.Reverse(koleksiyon);
        Array.Resize(ref koleksiyon, 3);

        System.Console.WriteLine("Girilen sayıların en küçük üçü: ");
        foreach (var item in ana_koleksiyon)
        {
            Console.WriteLine(item);
        }

        System.Console.WriteLine("Girilen sayıların en büyük üçü: ");
        foreach (var item in koleksiyon)
        {
            Console.WriteLine(item);
        }

    }
}

