using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("öğrenci sayısnı giriniz:");
            n = Convert.ToInt32(Console.ReadLine());
            not_hesaplama(n);
            Console.ReadLine();

        }
        static void not_hesaplama(int n)
        {
            int i, sayi1 = 0, sayi2 = 0;
            double final, vize, ort = 0,sınıfort=0,toplam=0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}.öğrencinin final ve fize notunu giriniz", i);
                final = Convert.ToDouble(Console.ReadLine());
                vize = Convert.ToDouble(Console.ReadLine());
                ort = (vize * 40 / 100) + (final * 60 / 100);
                toplam = toplam + ort;
                sınıfort = toplam / n;
               
                if (ort < 60)
                {
                   
                    sayi1++;   
                }
                else
                {

                   
                    sayi2++;
                }
            }
            Console.WriteLine("Sınıfın not ortalaması={0}",sınıfort);
                Console.WriteLine("BAŞARISIZ öğrenci sayısı={0}", sayi1);
                Console.WriteLine("BAŞARILI öğrenci sayısı={0}", sayi2);

            }
    }
}
       

            
 