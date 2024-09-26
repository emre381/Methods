using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     class Program
    {
        static void Main(string[] args)
        {
            string isimSoyad;
            int yas;
            double boy;

            Console.WriteLine("Lütfen değerleri girin isim soy isim");
            isimSoyad = Console.ReadLine();
            Console.WriteLine("Lütfen yaşınızı gitiniz:");
            yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu metre cinsinden giriniz:");
            boy = double.Parse(Console.ReadLine());
            isimSoyle(isimSoyad , yas , boy);

            dogunYiliHesapla(yas);
            Console.ReadLine();
        }

       
        static void isimSoyle(string i, int y, double b)
        {
            Console.WriteLine("Adı ve Soyadı : {0} Yaşınız :{1} Boyunuz {2} ",i,y,b);
        }

        static void dogunYiliHesapla(int yas)
        {
            Console.WriteLine("Doğum tarihiniz:" + (2024 - yas));  
        }
    }
}
