using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{

    class Program
    {
        static void Main(string[] args)
        {
            selamVer("Ali");
            selamVer("Ayşe");
            selamVer("Kemal");
            selamVer();
         
            int sonuc = Topla(6, 58);

            string ogrenci1 = "Yusuf";
            string ogrenci2 = "Cengiz";
            string ogrenci3 = "Dilay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Yusuf";
            ogrenciler[1] = "Cengiz";
            ogrenciler[2] = "Dilay";
            ogrenciler = new string[4];
            ogrenciler[3] = "Mehmet";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new string[] {"Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bitlis", "Kayseri", "Kocaeli" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Van";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Furkan";

            Person person2 = new Person();
            person2.FirstName = "Yakup";

            foreach (string sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> {"Van", "Muş", "Antalya" };
            yeniSehirler1.Add("Bolu");
            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void selamVer(string isim ="nonName")
        {
            Console.WriteLine("Merhaba "+ isim);
        }

        static int Topla(int sayi1=5, int sayi2=10) 
        {
           int sonuc = sayi1 + sayi2;
           Console.WriteLine("Toplam: " + sonuc);
           return sonuc;
        }

    }
}