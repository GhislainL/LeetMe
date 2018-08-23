using LeetMe;
using System;
using System.Text;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            FauxCyrillic fauxCyrillic = new FauxCyrillic();
            Leet leetMe = new Leet();

            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 10; i++)
            {
                string sentence = LoremNET.Lorem.Sentence(5, 10);
                Console.WriteLine(sentence);
                Console.WriteLine(fauxCyrillic.Translate(sentence));
                Console.WriteLine(leetMe.Translate(sentence, LeetLevel.Noob));
            }

            Console.WriteLine("end");
            Console.ReadLine();
        }

    }
}
