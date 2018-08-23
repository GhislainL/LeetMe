using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetMe
{
    public class LeetMe3
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

        Dictionary<char, List<string>> dicoDefinedList = new Dictionary<char, List<string>>();

        public LeetMe3()
        {
            dicoDefinedList.Add('a', arrA.ToList());
            dicoDefinedList.Add('b', arrB.ToList());
            dicoDefinedList.Add('c', arrC.ToList());
            dicoDefinedList.Add('d', arrD.ToList());
            dicoDefinedList.Add('e', arrE.ToList());
            dicoDefinedList.Add('f', arrF.ToList());
            dicoDefinedList.Add('g', arrG.ToList());
            dicoDefinedList.Add('h', arrH.ToList());
            dicoDefinedList.Add('i', arrI.ToList());
            dicoDefinedList.Add('j', arrJ.ToList());
            dicoDefinedList.Add('k', arrK.ToList());
            dicoDefinedList.Add('l', arrL.ToList());
            dicoDefinedList.Add('m', arrM.ToList());
            dicoDefinedList.Add('n', arrN.ToList());
            dicoDefinedList.Add('o', arrO.ToList());
            dicoDefinedList.Add('p', arrP.ToList());
            dicoDefinedList.Add('q', arrQ.ToList());
            dicoDefinedList.Add('r', arrR.ToList());
            dicoDefinedList.Add('s', arrS.ToList());
            dicoDefinedList.Add('t', arrT.ToList());
            dicoDefinedList.Add('u', arrU.ToList());
            dicoDefinedList.Add('v', arrV.ToList());
            dicoDefinedList.Add('w', arrW.ToList());
            dicoDefinedList.Add('x', arrX.ToList());
            dicoDefinedList.Add('y', arrY.ToList());
            dicoDefinedList.Add('z', arrZ.ToList());
        }

        public string Translate(string input, LeetLevel leetLevel)
        {
            int idx;
            string res = string.Empty;
            Random random = new Random();
            foreach (char c in input)
            {
                if (dicoDefinedList.ContainsKey(c))
                {
                    switch (leetLevel)
                    {
                        case LeetLevel.Noob:
                            res += dicoDefinedList[c][0];
                            break;
                        case LeetLevel.Leet:
                            idx = random.Next(dicoDefinedList[c].Count - 2);
                            res += dicoDefinedList[c][idx];
                            break;
                        case LeetLevel.Roxxor:
                            idx = random.Next(1, dicoDefinedList[c].Count - 1);
                            res += dicoDefinedList[c][idx];
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
