using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Benchmark
{
    public class BenchLeet
    {
        LeetMeUp.LeetMeUp LeetMeUpInstance;
        public BenchLeet()
        {
            LeetMeUpInstance = new LeetMeUp.LeetMeUp();
        }

        [Benchmark]
        public string NoobArrayInline()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Noob);
        }

        [Benchmark]
        public string LeetArrayInline()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Leet);
        }

        [Benchmark]
        public string RoxxorArrayInline()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Roxxor);
        }
    }

    public class BenchLeet4
    {
        LeetMeUp.LeetMeUp4 LeetMeUpInstance;
        public BenchLeet4()
        {
            LeetMeUpInstance = new LeetMeUp.LeetMeUp4();
        }
        
        [Benchmark]
        public string NoobArrayDefined()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Noob);
        }

        [Benchmark]
        public string LeetArrayDefined()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Leet);
        }

        [Benchmark]
        public string RoxxorArrayDefined()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Roxxor);
        }
    }

    public class BenchLeet2
    {
        LeetMeUp.LeetMeUp2 LeetMeUpInstance;
        public BenchLeet2()
        {
            LeetMeUpInstance = new LeetMeUp.LeetMeUp2();
        }

        [Benchmark]
        public string NoobDicoCharArray()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Noob);
        }

        [Benchmark]
        public string LeetDicoCharArray()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Leet);
        }

        [Benchmark]
        public string RoxxorDicoCharArray()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Roxxor);
        }
    }

    public class BenchLeet3
    {
        LeetMeUp.LeetMeUp3 LeetMeUpInstance;
        public BenchLeet3()
        {
            LeetMeUpInstance = new LeetMeUp.LeetMeUp3();
        }

        [Benchmark]
        public string NoobDicoCharList()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Noob);
        }

        [Benchmark]
        public string LeetDicoCharList()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Leet);
        }

        [Benchmark]
        public string RoxxorDicoCharList()
        {
            string sentence = LoremNET.Lorem.Sentence(5, 10);
            return LeetMeUpInstance.Translate(sentence, LeetMeUp.LeetLevel.Roxxor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchLeet>();
            var summary2 = BenchmarkRunner.Run<BenchLeet2>();
            var summary3 = BenchmarkRunner.Run<BenchLeet3>();
            var summary4 = BenchmarkRunner.Run<BenchLeet4>();

            Console.ReadLine();
        }
    }
}
