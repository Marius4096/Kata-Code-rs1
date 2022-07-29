using System;
using System.Collections.Generic;
using System.Text;

namespace Hëävÿ_Mëtäl_Ümläüts
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(HeavyMetalUmlauts("Announcing the Macbook Air Guitar"));
            Console.WriteLine(HeavyMetalUmlauts("Facebook introduces new heavy metal reaction buttons"));
            Console.WriteLine(HeavyMetalUmlauts("Strong sales of Google's VR Metalheadsets send tech stock prices soaring"));
            Console.WriteLine(HeavyMetalUmlauts("Vegan Black Metal Chef hits the big time on Amazon TV"));
        }
        public static string HeavyMetalUmlauts(string Text)
        {
            string str1 = "AEIOUYaeiouy";
            string str2 = "ÄËÏÖÜŸäëïöüÿ";
            for(int i = 0; i < str1.Length; i++)
            {
                Text = Text.Replace(str1[i], str2[i]);
            }
            return Text;
        }
    }
}
/*
 
 string str1 = "AEIOUYaeiouy";
            string str2 = "ÄËÏÖÜŸäëïöüÿ";
            for(int i = 0; i < str1.Length; i++)
            {
                Text = Text.Replace(str1[i], str2[i]);
            }
            return Text;


public static string HeavyMetalUmlauts(string boringText)
  {
    boringText = boringText.Replace("A", "Ä" );
    boringText = boringText.Replace("O", "Ö" );
    boringText = boringText.Replace("a", "ä" );
    boringText = boringText.Replace("o", "ö" );
    boringText = boringText.Replace("E", "Ë" );
    boringText = boringText.Replace("U", "Ü" );
    boringText = boringText.Replace("e", "ë" );
    boringText = boringText.Replace("u", "ü" );
    boringText = boringText.Replace("I", "Ï" );
    boringText = boringText.Replace("Y", "Ÿ" );
    boringText = boringText.Replace("i", "ï" );
    boringText = boringText.Replace("y", "ÿ" );
    return boringText;
  }  



 
 */