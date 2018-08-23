using System;
using System.Collections.Generic;

namespace LeetMe
{
    public class Leet2
    {
        static string[] arrA = new string[] { "4", "/\\", "@", "^", "aye", "∂", "/-\\", "|-\\", "q" };
        static string[] arrB = new string[] { "8", "6", "13", "|3", "ß", "P>", "|:", "!3", "(3", "/3", ")3", "I3" };
        static string[] arrC = new string[] { "(", "¢", "<", "[", "©" };
        static string[] arrD = new string[] { "d", "[)", "|o", ")", "I>", "|>", "?", "T)", "|)", "0", "</", "Đ" };
        static string[] arrE = new string[] { "3", "&", "€", "£", "є", "ë", "[-", "|=-", "Ǝ" };
        static string[] arrF = new string[] { "f", "|=", "ƒ", "|#", "ph", "/=", "Ƒ" };
        static string[] arrG = new string[] { "9", "6", "&", "(_+", "C-", "gee", "(γ," };
        static string[] arrH = new string[] { "#", "/-/", "[-]", "]-[", ")-(", "(-)", ":-:", "|~|", "|-|", "]~[", "}{", "]-[", "?", "}-{", "hèch" };
        static string[] arrI = new string[] { "!", "1", "|", "][", "eye", "3y3", "]", ":" };
        static string[] arrJ = new string[] { "j", "_|", "_/", "¿", "</", "(/", "ʝ", ";" };
        static string[] arrK = new string[] { "k", "|<", "X", "|{", "ɮ", "<", "|\\“" };
        static string[] arrL = new string[] { "1", "|_", "1_", "ℓ", "|", "][_,", "£" };
        static string[] arrM = new string[] { "m", "|v|", "[V]", "{V}", "|\\/|", "/\\/\\", "(u)", "(V)", "(\\/)", "/|\\", "^^", "/|/|", "//.", ".\\\\", "/^^\\", "///", "|^^|" };
        static string[] arrN = new string[] { "~", "|\\|", "^/", "|V", "/\\/", "[\\]", "<\\>", "{\\}", "]\\[", "//", "^", "[]", "/V", "₪" };
        static string[] arrO = new string[] { "0", "()", "oh", "[]", "¤", "°", "([])" };
        static string[] arrP = new string[] { "p", "9", "|*", "|o", "|º", "|^(o)", "|>", "\"|\"\"\"", "[]D", "|̊", "|7", "?", "/*", "¶", "/*" };
        static string[] arrQ = new string[] { "q", "(_,)", "()_", "0_", "°|", "<|", "0." };
        static string[] arrR = new string[] { "r", "|2", "2", "|?", "/2", "|^", "lz", "®", "[z", "12", "Я", "ʁ", "|²", ".-", ",-", "|°\\" };
        static string[] arrS = new string[] { "5", "$", "z", "§", "ehs", "es", "_/¯" };
        static string[] arrT = new string[] { "7", "+", "-|-", "1", "']['", "†", "|²", "¯|¯" };
        static string[] arrU = new string[] { "u", "(_)", "|_|", "v", "L|", "µ", "J" };
        static string[] arrV = new string[] { "v", "\\/", "1/", "|/", "o|o", "▼" };
        static string[] arrW = new string[] { "w", "\\/\\/", "vv", "'//", "\\\\`", "\\^/", "(n)", "\\V/", "\\X/", "\\|/", "\\_|_/", "\\_:_/", "?", "?", "`^/", "\\./" };
        static string[] arrX = new string[] { "*", "><", "Ж", "}{", "ecks", "×", ")(" };
        static string[] arrY = new string[] { "y", "7", "j", "`/", "Ψ", "φ", "λ", "Ч", "¥", "'/" };
        static string[] arrZ = new string[] { "2", "≥", "=/=", "7_", "~/_", "%", ">_", ">_", "-\\_", "'/_" };

        Dictionary<char, string[]> dicoDefinedArray = new Dictionary<char, string[]>();

        public Leet2()
        {
            dicoDefinedArray.Add('a', arrA);
            dicoDefinedArray.Add('b', arrB);
            dicoDefinedArray.Add('c', arrC);
            dicoDefinedArray.Add('d', arrD);
            dicoDefinedArray.Add('e', arrE);
            dicoDefinedArray.Add('f', arrF);
            dicoDefinedArray.Add('g', arrG);
            dicoDefinedArray.Add('h', arrH);
            dicoDefinedArray.Add('i', arrI);
            dicoDefinedArray.Add('j', arrJ);
            dicoDefinedArray.Add('k', arrK);
            dicoDefinedArray.Add('l', arrL);
            dicoDefinedArray.Add('m', arrM);
            dicoDefinedArray.Add('n', arrN);
            dicoDefinedArray.Add('o', arrO);
            dicoDefinedArray.Add('p', arrP);
            dicoDefinedArray.Add('q', arrQ);
            dicoDefinedArray.Add('r', arrR);
            dicoDefinedArray.Add('s', arrS);
            dicoDefinedArray.Add('t', arrT);
            dicoDefinedArray.Add('u', arrU);
            dicoDefinedArray.Add('v', arrV);
            dicoDefinedArray.Add('w', arrW);
            dicoDefinedArray.Add('x', arrX);
            dicoDefinedArray.Add('y', arrY);
            dicoDefinedArray.Add('z', arrZ);
        }

        public string Translate(string input, LeetLevel leetLevel)
        {
            int idx;
            string res = string.Empty;
            Random random = new Random();
            foreach (char c in input)
            {
                if (dicoDefinedArray.ContainsKey(c))
                {
                    switch (leetLevel)
                    {
                        case LeetLevel.Noob:
                            res += dicoDefinedArray[c][0];
                            break;
                        case LeetLevel.Leet:
                            idx = random.Next(dicoDefinedArray[c].Length - 2);
                            res += dicoDefinedArray[c][idx];
                            break;
                        case LeetLevel.Roxxor:
                            idx = random.Next(1, dicoDefinedArray[c].Length - 1);
                            res += dicoDefinedArray[c][idx];
                            break;
                        default:
                            break;
                    }
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
