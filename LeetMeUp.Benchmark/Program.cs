using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Benchmark
{
    [CoreJob]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchNoob
    {
        private readonly string sentence;

        private readonly LeetMeUp.LeetMeUp LeetMeUpInstance1 = new LeetMeUp.LeetMeUp();
        private readonly LeetMeUp.LeetMeUp2 LeetMeUpInstance2 = new LeetMeUp.LeetMeUp2();
        private readonly LeetMeUp.LeetMeUp3 LeetMeUpInstance3 = new LeetMeUp.LeetMeUp3();
        private readonly LeetMeUp.LeetMeUp4 LeetMeUpInstance4 = new LeetMeUp.LeetMeUp4();

        public BenchNoob()
        {
            sentence = LoremNET.Lorem.Sentence(5, 10);
        }

        [Benchmark]
        public string NoobArrayInline()
        {
            return LeetMeUpInstance1.Translate(sentence, LeetMeUp.LeetLevel.Noob);
        }

        [Benchmark]
        public string NoobArrayDefined()
        {
            return LeetMeUpInstance4.Translate(sentence, LeetMeUp.LeetLevel.Noob);
        }

        [Benchmark]
        public string NoobDicoCharArray()
        {
            return LeetMeUpInstance2.Translate(sentence, LeetMeUp.LeetLevel.Noob);
        }

        [Benchmark]
        public string NoobDicoCharList()
        {
            return LeetMeUpInstance3.Translate(sentence, LeetMeUp.LeetLevel.Noob);
        }
    }

    [CoreJob]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchLeet
    {
        private readonly string sentence;

        private readonly LeetMeUp.LeetMeUp LeetMeUpInstance1 = new LeetMeUp.LeetMeUp();
        private readonly LeetMeUp.LeetMeUp2 LeetMeUpInstance2 = new LeetMeUp.LeetMeUp2();
        private readonly LeetMeUp.LeetMeUp3 LeetMeUpInstance3 = new LeetMeUp.LeetMeUp3();
        private readonly LeetMeUp.LeetMeUp4 LeetMeUpInstance4 = new LeetMeUp.LeetMeUp4();

        public BenchLeet()
        {
            sentence = LoremNET.Lorem.Sentence(5, 10);
        }

        [Benchmark]
        public string NoobArrayInline()
        {
            return LeetMeUpInstance1.Translate(sentence, LeetMeUp.LeetLevel.Leet);
        }

        [Benchmark]
        public string NoobArrayDefined()
        {
            return LeetMeUpInstance4.Translate(sentence, LeetMeUp.LeetLevel.Leet);
        }

        [Benchmark]
        public string NoobDicoCharArray()
        {
            return LeetMeUpInstance2.Translate(sentence, LeetMeUp.LeetLevel.Leet);
        }

        [Benchmark]
        public string NoobDicoCharList()
        {
            return LeetMeUpInstance3.Translate(sentence, LeetMeUp.LeetLevel.Leet);
        }
    }

    [CoreJob]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchRoxxor
    {
        private readonly string sentence;

        private readonly LeetMeUp.LeetMeUp LeetMeUpInstance1 = new LeetMeUp.LeetMeUp();
        private readonly LeetMeUp.LeetMeUp2 LeetMeUpInstance2 = new LeetMeUp.LeetMeUp2();
        private readonly LeetMeUp.LeetMeUp3 LeetMeUpInstance3 = new LeetMeUp.LeetMeUp3();
        private readonly LeetMeUp.LeetMeUp4 LeetMeUpInstance4 = new LeetMeUp.LeetMeUp4();

        public BenchRoxxor()
        {
            sentence = LoremNET.Lorem.Sentence(5, 10);
        }

        [Benchmark]
        public string NoobArrayInline()
        {
            return LeetMeUpInstance1.Translate(sentence, LeetMeUp.LeetLevel.Roxxor);
        }

        [Benchmark]
        public string NoobArrayDefined()
        {
            return LeetMeUpInstance4.Translate(sentence, LeetMeUp.LeetLevel.Roxxor);
        }

        [Benchmark]
        public string NoobDicoCharArray()
        {
            return LeetMeUpInstance2.Translate(sentence, LeetMeUp.LeetLevel.Roxxor);
        }

        [Benchmark]
        public string NoobDicoCharList()
        {
            return LeetMeUpInstance3.Translate(sentence, LeetMeUp.LeetLevel.Roxxor);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var summary1 = BenchmarkRunner.Run<BenchNoob>();
            var summary2 = BenchmarkRunner.Run<BenchLeet>();
            var summary3 = BenchmarkRunner.Run<BenchRoxxor>();

            Console.ReadLine();
        }
    }
}
