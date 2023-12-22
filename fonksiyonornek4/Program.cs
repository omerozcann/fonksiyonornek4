using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyonornek4
{
    internal class Program
    {
        static int enbuyukbul(int[]sayilar)
        {
            int buyuk = int.MinValue;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>buyuk)
                {
                    buyuk = sayilar[i];
                }
            }
            return buyuk;   
        }
        static void Main(string[] args)
        {
            /*
             Örnek: Kendisine gönderilen sayı dizisindeki en büyük sayıyı
            bulup geri döndüren fonksiyonu yazınız.
             */
            //int[] dizi = { 1, 2, 3, 4, 5 };
            //int s;
            //s= enbuyukbul(dizi);
            //Console.WriteLine("Sonuç={0}",s);

            //sayıları kullanıcıdan alalım
            int[] dizi = new int[5];
            int s;
            for (int i = 0;i < dizi.Length;i++)
            {
                Console.WriteLine("Bir sayı gir:");
                dizi[i]=int.Parse(Console.ReadLine());
            }
            s = enbuyukbul(dizi);
            Console.WriteLine("Sonuç={0}", s);
        }
    }
}
