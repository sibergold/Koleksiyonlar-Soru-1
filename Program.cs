using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Koleksiyonlar1.soru
{
    class Program
    {

        static void Main(string[] args)
        {

            ArrayList asalsayilar = new ArrayList();
            ArrayList asalolmayansayilar = new ArrayList();
            int kronometre = 1;
            double asaltoplam = 0;
            double asalolmayantoplam = 0;
            while (kronometre < 21)
            {
                Console.WriteLine(kronometre + ". sayıyı girin.");

                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0)
                {
                    Console.WriteLine("Lütfen geçerli bir değer gir.");
                }


                else
                {

                    int sonuc = asalmi(sayi);
                    if (sonuc == 0)
                    {
                        asalolmayansayilar.Add(sayi);
                        kronometre++;
                        asalolmayantoplam += sayi;
                    }
                    else
                    {
                        asalsayilar.Add(sayi);
                        kronometre++;
                        asaltoplam += sayi;
                    }
                }
            }

            Console.WriteLine("*** ASAL SAYILAR ***");
            foreach (var item in asalsayilar)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("*** ASAL OLMAYAN SAYILAR ***");
            foreach (var item in asalolmayansayilar)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine( "ASAL  SAYILAR TOPLAMI:" + asaltoplam);
            Console.WriteLine(" ASAL OLMAYAN SAYILAR TOPLAMI:"+asalolmayantoplam);
            Console.WriteLine("ASAL SAYI MİKTARI:" + asalsayilar.Count);
            Console.WriteLine("ASAL OLMAYAN SAYI MİKTARI:" + asalolmayansayilar.Count);
            Console.WriteLine("ASAL SAYILARIN ORTALAMASI:" + asaltoplam/asalsayilar.Count);
            Console.WriteLine("ASAL OLMAYAN SAYILARIN ORTALAMASI:" + asalolmayantoplam/asalolmayansayilar.Count);
           asalsayilar.Reverse();
           asalolmayansayilar.Reverse();
           object[] dizi=new object[asalsayilar.Count];
           for(int i=0;i<asalsayilar.Count;i++){
              dizi[i]=asalsayilar[i];
                
           } 
            object[] dizi2=new object[asalolmayansayilar.Count];
        for(int i=0;i<asalolmayansayilar.Count;i++){
              dizi2[i]=asalolmayansayilar[i];
                
           }  
       Console.WriteLine("*** BÜYÜKTEN KÜÇÜĞE ASAL SAYILAR");
        foreach(var item in dizi){
            Console.WriteLine(item);
        }
        Console.WriteLine("*** BÜYÜKTEN KÜÇÜĞE ASAL OLMAYAN SAYILAR");
        foreach(var item in dizi2){
            Console.WriteLine(item);
        }
        }
        public static int asalmi(int sayi2)
        {
            int i;
            for (i = 2; i <= sayi2 - 1; i++)
            {
                if (sayi2 % i == 0 || sayi2 == 1)
                {
                    return 0;
                }
            }
            if (i == sayi2) // 2 rakamı da bir asal sayı olduğu için i=2 olduğunda direk asal sayı olarak algılanmasını istiyoruz
            {
                return 1;
            }
            return 0;
        }

    }
}
