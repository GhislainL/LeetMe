using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            LeetMeUp.FauxCyrillic fauxCyrillic = new LeetMeUp.FauxCyrillic();
            LeetMeUp.LeetMeUp leetMeUp = new LeetMeUp.LeetMeUp();

            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 10; i++)
            {
                string sentence = LoremNET.Lorem.Sentence(5, 10);
                Console.WriteLine(sentence);
                Console.WriteLine(fauxCyrillic.Translate(sentence));
                Console.WriteLine(leetMeUp.Translate(sentence, LeetMeUp.LeetLevel.Noob));
            }

            Console.WriteLine("end");
            Console.ReadLine();
        }

    }
}
