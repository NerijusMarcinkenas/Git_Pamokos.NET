using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrukturosIrUnitTestai
{
    class ID_Generator
    {
       
        static string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public static Random random = new Random();
        public ID_Generator(string chars)
        {
            Chars = chars;
        }
         public static string GetID()
         {            
            return new string(Enumerable.Repeat(Chars,5).Select(s => s[random.Next(Chars.Length)]).ToArray());
         }


        
    }
}
