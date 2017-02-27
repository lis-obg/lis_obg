using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Program2{
    internal class Program{
        public static void Main(string[] args)
        {
            System.Text.StringBuilder f1, f2;
            f1 = new StringBuilder();
            f2 = new StringBuilder();
/*
            //data filling
            System.Text.StringBuilder tempWord = new StringBuilder();
            tempWord.Append("");
            System.Console.WriteLine("Write you text here:");
            f1.Append(System.Console.ReadLine());
            System.Console.Clear();
            int i = 0;
            while (Convert.ToInt16(tempWord) != 0 || i != 15){    //no more then 30 words
                f2.Append(",").Append(tempWord).;
                System.Console.WriteLine("For exit write: 0");
                System.Console.WriteLine("Write word and his synonym here:");
                System.Console.WriteLine("<word>,<synonym>");
                tempWord.Append(System.Console.ReadLine());
                i++;
                System.Console.Clear();
            }
*/
             f1.Append("Текст (от лат. textus — «ткань; сплетение, связь, сочетание») — зафиксированная на каком-либо "+
                        "материальном носителе человеческая мысль; в общем плане связная и полная последовательность символов."+
                        "Существуют две основные трактовки понятия «текст»: «имманентная» (расширенная, философски нагруженная) и "+
                        "«репрезентативная» (более частная). Имманентный подход подразумевает отношение к тексту как к автономной"+
                        " реальности, нацеленность на выявление его внутренней структуры. ");

            f2.Append("материальном,существующем,мысль,идея,структуры,устройства");


        }
    }
}