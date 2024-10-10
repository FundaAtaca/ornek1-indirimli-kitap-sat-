using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // adet fiyatı 8 tl olan kitaplardan 20 adede kadar alımlarda %20, 20-50 adet arası alımlarda %40; 
           // 50 ve üzeri alımlar için %50 indirimli fiyatı hesaplayan kodu yazınız

            Console.Write("Lütfen aldığınız kitap adedini giriniz: ");
            int adet=int.Parse(Console.ReadLine());

            int fiyat = 8;
            double totaltutar;

            if (adet > 0 & adet <= 20)
            {
                totaltutar = adet * fiyat * 0.8;
                Console.Write("Aldığınız " + adet + " kitap için indirimli fiyat: " + totaltutar + " TL'dir.");

            }
            if(adet>20 & adet<=50)
            {
                totaltutar = adet * fiyat * 0.6;
                Console.Write("Aldığınız " + adet + " kitap için indirimli fiyat: " + totaltutar + " TL'dir.");
            }
            if(adet>50)
            {
                totaltutar = adet * fiyat * 0.5;
                Console.Write("Aldığınız " + adet + " kitap için indirimli fiyat: " + totaltutar + " TL'dir.");
            }
            Console.Read();



        }
    }
}
