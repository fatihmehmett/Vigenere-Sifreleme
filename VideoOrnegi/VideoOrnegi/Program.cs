using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkenler
            string kelime, anahtar, sifreli_kelime="";
            int anahtar_kelime_sayac = 0;

            Console.WriteLine("Şifreliyeceğiniz kelimeyi giriniz: ");
            kelime = Console.ReadLine();
            Console.WriteLine("Anahtar kelimeyi giriniz");
            anahtar = Console.ReadLine();

            //Vigenere şifreleme için gerekli formul

            
            for (int i = 0; i < kelime.Length; i++)
            {
                int formul;
                formul = ((kelime[i] - 97) + (anahtar[anahtar_kelime_sayac % anahtar.Length])-97) % 26;
                sifreli_kelime += (char)(formul + 97);
                anahtar_kelime_sayac++;
            }
            //şifreli kelimeyi ekrana yazıyoruz.
            Console.WriteLine("şifreli kelimemiz: " + sifreli_kelime);
            Console.ReadKey();

        }
    }
}
