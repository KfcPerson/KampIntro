﻿using System.Runtime.InteropServices;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);

        List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);
        isimler2.Add("Ilker");
        Console.WriteLine(isimler2[4]);
        Console.WriteLine(isimler2[0]);
    }
}