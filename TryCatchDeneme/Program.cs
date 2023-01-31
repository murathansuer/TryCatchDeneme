using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace TryCatchDeneme
{
    internal class Program
    {
       
        static void Main(string[] args)

                    //// KENDİME NOT!!
                    ///////// SWITCH CASE BREAK YAPISINI ACIL OGREN, 
                    ///DAHA HIZLI İLERLEME İÇİN
                    ///BÜTÜN KODLARI IF İLE YAZMAYA ÇALIŞMA 
        {
            double x;
            double y;
            int deger;
    

            try
            {
                Console.WriteLine("Değer Giriniz:");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Değer Giriniz:");
                y = Convert.ToDouble(Console.ReadLine());

                double z = x + y, zz = x - y, zzz = x * y, zzzz = x / y;

                Console.WriteLine("Hangi İşlemi Yapmak İstiyorsunuz?");
                Console.WriteLine("1-Toplama, 2-Çıkarma, 3-Çarpma, 4-Bölme");
                deger = Convert.ToInt32(Console.ReadLine());

                if (deger == 1)
                {
                    Console.WriteLine(z);
                }
                        if (deger == 2)
                        {
                            Console.WriteLine(zz);
                        }
                                if (deger == 3)
                                {
                                    Console.WriteLine(zzz);
                                }
                                        if (deger == 4)
                                        {
                                            Console.WriteLine(zzzz);
                                        }
                                            if (deger >=5)
                                            {
                                                Console.WriteLine("Hata");
                                           }
                                                 if( deger <= 0)
                                                        {
                                                            Console.WriteLine("Hata");
                                                        }

            }

            catch(Exception ex)
            {
                Console.WriteLine("Hata " + ex.Message.ToString());
            }
      


        }
    }
}
