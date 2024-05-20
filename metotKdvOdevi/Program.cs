using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotKdvOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Ödev
             Kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayacak method yazılacak.
             ve kullanıcı 3. ürünü almak isterse 3. ürüne %50 indirim uygulayacak method yazılacak.
             2 ürün yada 3 ürün için kullanıcının ne kadar fiyat ödemesi gerektiği gösterilecek.     
             2 adet method kullanılacak. ilki 2 ürün için ikincisi 3 ürün için çalışacak.
             */

            try
            {
                Console.WriteLine("lütfen birinci ürünün fiyatını giriniz");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("lütfen ikinci ürünün fiyatını giriniz");
                int sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine("üçüncü ürünü almak istermisiniz eğer almak istiyorsanız '1' almak istemiyorsanız '2' yi tuşlayınız");
                int istek = int.Parse(Console.ReadLine());

                if (istek == 1)
                {
                    Console.WriteLine("lütfen Üçüncü ürünün fiyatını giriniz");
                    int sayi3 = int.Parse(Console.ReadLine());

                    UcKdvliFiyat(sayi1, sayi2, sayi3);

                }

                else if (istek == 2)
                {
                    IkiKdvliFiyat(sayi1, sayi2);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("bir hata oluştu");
            }

        }
        static void UcKdvliFiyat(double s1, double s2, double s3)
        {

            if (s1 > s2)
            {
                double banko = s3 * 1.50;
                double sonucUc = s1 * 1.30;
                Console.WriteLine($"alınan Üç ürün için {sonucUc + s2 + banko}  TL ödenecek");

            }

            else if (s1 < s2)
            {
                double banko = s3 * 1.50;
                double sonucUcIki = s1 * 1.30;
                Console.WriteLine($"alınan Üç ürün için {sonucUcIki + s1 + banko} TL ödenecek");
            }
            else
            {
                Console.WriteLine("Sonuc Sıfırdır");
            }
            Console.ReadLine();
        }

        static void IkiKdvliFiyat(int s1, int s2)
        {
            if (s1 > s2)
            {
                double sonucUc = s1 * 1.30;
                Console.WriteLine($"alınan Üç ürün için {sonucUc + s2} TL ödenecek");

            }

            else if (s1 < s2)
            {
                double sonucUcIki = s1 * 1.30;
                Console.WriteLine($"alınan Üç ürün için {sonucUcIki + s1} TL ödenecek");
            }
            Console.ReadLine();
        }
    }
}
