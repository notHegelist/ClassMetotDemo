using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Yeni Eklenen Müşteri: ");
            Console.WriteLine(" ");
            Console.WriteLine(musteri.TC + "           " + musteri.Ad + "      " + musteri.Soyad + "  " + musteri.Yas);


        }

         





        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Bu Müşteri Listeden Kaldırılmıştır :    " + musteri.Ad + musteri.Soyad);
        }





        public void Listele(Musteri[] musteris)
        {
            foreach (var musteri in musteris)
            {
                
                Console.WriteLine(" ");
                Console.WriteLine(musteri.TC +"           "  + musteri.Ad  +"      "+ musteri.Soyad  +"  "+ musteri.Yas);
                
            }
        }
    
            



    }
}
