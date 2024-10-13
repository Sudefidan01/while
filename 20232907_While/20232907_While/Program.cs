using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20232907_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Döngüsü
            //Program içerisinde bazı durumlarda belirli komut satırlarını defalarca kez kullanmak isteyebiliriz.
            //Bu gibi durumlarda döngü mekanizmaları devreye girer
            //While döngüsü dögünün kaç defa  döneceği belli olmayan durumlarda kullanılır
            //While döngüsünde koşul alanı vardır.
            //Bu koşul true olduğu sürece döngü içerisindeki komut satırları işlemeye devam eder.

            // Syntax(Yazım Kuralı)
            // while(koşul)
            //{
            //komut satırı
            //komut satırı
            //komut satırı
            //}

            // 1'den 10'a kadar olan sayıları while döngüsü ile yazdıralım

            int sayac = 1, hedef = 10;
            while (sayac<=hedef)
            {
                Console.WriteLine(sayac);
                sayac++; // ++ komut sayıyı +1 artıracağımızı gösterir
            }
            Console.ReadKey();
        }
        
    }
}
