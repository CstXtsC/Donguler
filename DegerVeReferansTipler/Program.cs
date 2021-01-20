using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? --> 30 doğru yaptım
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };   // bu bir array(dizi)dir.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? --> 999 doğru yaptım
            Console.WriteLine(sayilar1[0]);


        }
    }
}
