using System;
using System.Collections.Generic;
using System.Text;

namespace LeetMe
{
    //https://fr.wikipedia.org/wiki/Faux_cyrillique
    public class FauxCyrillic
    {
        Dictionary<char, char> dicoDefinedList = new Dictionary<char, char>();

        public FauxCyrillic()
        {
            dicoDefinedList.Add('a', 'Д');
            //dicoDefinedList.Add('e', 'З');
            dicoDefinedList.Add('e', 'Э');
            dicoDefinedList.Add('l', 'Г');
            dicoDefinedList.Add('n', 'И');
            dicoDefinedList.Add('o', 'Ф');
            dicoDefinedList.Add('r', 'Я');
            dicoDefinedList.Add('u', 'Ц');
            dicoDefinedList.Add('w', 'Ш');
            //dicoDefinedList.Add('y', 'У');
            dicoDefinedList.Add('y', 'Ч');
        }

        public string Translate(string input)
        {
            string res = string.Empty;
            Random random = new Random();
            foreach (char c in input)
            {
                if (dicoDefinedList.ContainsKey(c))
                {
                    res += dicoDefinedList[c];
                }
                else
                {
                    res += c;
                }
            }

            return res;
        }

    }
}
