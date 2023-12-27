// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        string kurs1 = "Yazilim";
        string kurs2 = "Programlama";
        string kurs3 = "Java";


        //array
        string[] kurslar = new string[] { "Yazilim", "Programlama", "Java" };

         for (int i = 0; i <kurslar.Length; i++) 
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("for bitti");
         foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);

        }


    }





}


