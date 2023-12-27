// See https://aka.ms/new-console-template for more information
//type safety - tip guvenligi
//do not repeat yourself
//deger tutucu, alias

namespace KampItnro
{

    class Program
    {

        

        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.4;
            bool sistemeGirisYamisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            Console.WriteLine(faizOrani);
            Console.WriteLine(ogrenciSayisi); Console.WriteLine(dolarDun); Console.WriteLine(dolarBugun);  

           if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
           
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else 
            { 
                Console.WriteLine("Degismedi Butonu"); 
            }


            if (sistemeGirisYamisMi == true) {
                Console.WriteLine("Kullanici ayarlari butonu");
            
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

        }

        



    }

}