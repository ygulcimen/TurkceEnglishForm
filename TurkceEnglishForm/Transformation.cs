using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkceEnglishForm
{
    class Transformation
    {
        string[] TurkceKarakterler = { "ç", "ğ","ı", "ö", "ş", "ü", "Ç", "Ğ", "Ö","İ","Ü","Ş" };
        string[] IngilizceKarakterler = { "c", "g", "i", "o", "s", "u", "C", "G", "O", "I", "U", "S" };
        public string Trans(string metin)
        {
            string kelime = "";
            for (int i = 0; i <= metin.Length- 1; i++)
            {
                if (!(TurkceKarakterler.Contains(metin[i].ToString())))
                {
                    kelime += metin[i];
                }
                else
                {
                    for (int j = 0; j <= TurkceKarakterler.Length-1; j++)
                    {
                        if (metin[i].ToString() == TurkceKarakterler[j])
                        {
                            kelime += IngilizceKarakterler[j];
                        }

                    }

                }    
                
                


            }
            return kelime;

        }
        
        
    }
}
