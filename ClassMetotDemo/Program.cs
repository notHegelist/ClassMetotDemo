using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MÜŞTERİ LİSTESİ:");
            Console.WriteLine("");
            Console.WriteLine("Musteri T.C" + "           Ad" + "                Soyad" + "         Yas");
            
            
            Musteri musteri1 = new Musteri();
            musteri1.TC = 92345678910;
            musteri1.Ad = "Ahmet Mümtaz";
            musteri1.Soyad = "TAYLAN      ";
            musteri1.Yas = 55;

            Musteri musteri2 = new Musteri();
            musteri2.TC = 90987654321;
            musteri2.Ad = "Serkan      ";
            musteri2.Soyad = "KESKİN      ";
            musteri2.Yas = 45;

            Musteri musteri3 = new Musteri();
            musteri3.TC = 90864213579;
            musteri3.Ad = "Ali         ";
            musteri3.Soyad = "ATAY        ";
            musteri3.Yas = 43;

            Musteri musteri4 = new Musteri();
            musteri4.TC = 95489891041;
            musteri4.Ad = "Osman       ";
            musteri4.Soyad = "SONANT      ";
            musteri4.Yas = 42;

            Musteri musteri5 = new Musteri();
            musteri5.TC = 95000091041;
            musteri5.Ad = "Sıdkı       ";
            musteri5.Soyad = "SIYRILMIŞ   ";
            musteri5.Yas = 99;

            Musteri musteri6 = new Musteri();
            musteri6.TC = 50000778941;
            musteri6.Ad = "Memiş       ";
            musteri6.Soyad = "MEMİŞOĞLU   ";
            musteri6.Yas = 4;

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            
            Console.WriteLine(" ");
            MusteriManager musteriManager = new MusteriManager();

           

            musteriManager.Listele(musteris);
            Console.WriteLine("");

            musteriManager.Ekle(musteri5);
            Console.WriteLine(" ");
            musteriManager.Ekle(musteri6);
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            musteriManager.Sil(musteri5);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.ReadLine();



        }
    }

}
