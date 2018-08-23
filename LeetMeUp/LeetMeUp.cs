using System;

namespace LeetMeUp
{
    public class LeetMeUp
    {
        string[][] arrayInline = {
            new string[] {"4","/\\","@","^","aye","∂","/-\\","|-\\","q"},
            new string[] {"8","6","13","|3","ß","P>","|:","!3","(3","/3",")3","I3"},
            new string[] {"(","¢","<","[","©"},
            new string[] {"d","[)","|o",")","I>","|>","?","T)","|)","0","</","Đ"},
            new string[] {"3","&","€","£","є","ë","[-","|=-","Ǝ"},
            new string[] {"f","|=","ƒ","|#","ph","/=","Ƒ"},
            new string[] {"9","6","&","(_+","C-","gee","(γ,"},
            new string[] {"#","/-/","[-]","]-[",")-(","(-)",":-:","|~|","|-|","]~[","}{","]-[","?","}-{","hèch"},
            new string[] {"!","1","|","][","eye","3y3","]",":"},
            new string[] {"j","_|","_/","¿","</","(/","ʝ",";"},
            new string[] {"k","|<","X","|{","ɮ","<","|\\“"},
            new string[] {"1","|_","1_","ℓ","|","][_,","£"},
            new string[] {"m","|v|","[V]","{V}","|\\/|","/\\/\\","(u)","(V)","(\\/)","/|\\","^^","/|/|","//.",".\\\\","/^^\\","///","|^^|"},
            new string[] {"~","|\\|","^/","|V","/\\/","[\\]","<\\>","{\\}","]\\[","//","^","[]","/V","₪"},
            new string[] {"0","()","oh","[]","¤","°","([])"},
            new string[] {"p","9","|*","|o","|º","|^(o)","|>","\"|\"\"\"","[]D","|̊","|7","?","/*","¶","/*"},
            new string[] {"q","(_,)","()_","0_","°|","<|","0."},
            new string[] {"r","|2","2","|?","/2","|^","lz","®","[z","12","Я","ʁ","|²",".-",",-","|°\\"},
            new string[] {"5","$","z","§","ehs","es","_/¯"},
            new string[] {"7","+","-|-","1","']['","†","|²","¯|¯"},
            new string[] {"u","(_)","|_|","v","L|","µ","J"},
            new string[] {"v","\\/","1/","|/","o|o","▼"},
            new string[] {"w","\\/\\/","vv","'//","\\\\`","\\^/","(n)","\\V/","\\X/","\\|/","\\_|_/","\\_:_/","?","?","`^/","\\./"},
            new string[] {"*","><","Ж","}{","ecks","×",")("},
            new string[] {"y","7","j","`/","Ψ","φ","λ","Ч","¥","'/"},
            new string[] {"2","≥","=/=","7_","~/_","%",">_",">_","-\\_","'/_"}
        };

        public LeetMeUp()
        {
        }

        public string Translate(string input, LeetLevel leetLevel)
        {
            int idx;
            string res = string.Empty;
            Random random = new Random();
            foreach (char c in input)
            {
                if (c >= 97 && c <= 122)
                {
                    int relIndex = Convert.ToInt32(c) - 97;
                    switch (leetLevel)
                    {
                        case LeetLevel.Noob:
                            res += arrayInline[relIndex][0];
                            break;
                        case LeetLevel.Leet:
                            idx = random.Next(arrayInline[relIndex].Length - 2);
                            res += arrayInline[relIndex][idx];
                            break;
                        case LeetLevel.Roxxor:
                            idx = random.Next(1, arrayInline[relIndex].Length - 1);
                            res += arrayInline[relIndex][idx];
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
