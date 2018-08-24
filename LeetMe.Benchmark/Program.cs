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

        private readonly LeetMe.Leet LeetMeInstance1 = new LeetMe.Leet();
        private readonly LeetMe.Leet2 LeetMeInstance2 = new LeetMe.Leet2();
        private readonly LeetMe.LeetMe3 LeetMeInstance3 = new LeetMe.LeetMe3();
        private readonly LeetMe.LeetMe4 LeetMeInstance4 = new LeetMe.LeetMe4();

        public BenchNoob()
        {
            sentence = LoremNET.Lorem.Sentence(5, 10);
        }

        [Benchmark]
        public string NoobArrayInline()
        {
            return LeetMeInstance1.Translate(sentence, LeetMe.LeetLevel.Noob);
        }

        [Benchmark]
        public string NoobArrayDefined()
        {
            return LeetMeInstance4.Translate(sentence, LeetMe.LeetLevel.Noob);
        }

        [Benchmark]
        public string NoobDicoCharArray()
        {
            return LeetMeInstance2.Translate(sentence, LeetMe.LeetLevel.Noob);
        }

        [Benchmark]
        public string NoobDicoCharList()
        {
            return LeetMeInstance3.Translate(sentence, LeetMe.LeetLevel.Noob);
        }
    }

    [CoreJob]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchLeet
    {
        private readonly string sentence;

        private readonly LeetMe.Leet LeetMeInstance1 = new LeetMe.Leet();
        private readonly LeetMe.Leet2 LeetMeInstance2 = new LeetMe.Leet2();
        private readonly LeetMe.LeetMe3 LeetMeInstance3 = new LeetMe.LeetMe3();
        private readonly LeetMe.LeetMe4 LeetMeInstance4 = new LeetMe.LeetMe4();

        public BenchLeet()
        {
            sentence = LoremNET.Lorem.Sentence(5, 10);
        }

        [Benchmark]
        public string LeetArrayInline()
        {
            return LeetMeInstance1.Translate(sentence, LeetMe.LeetLevel.Leet);
        }

        [Benchmark]
        public string LeetArrayDefined()
        {
            return LeetMeInstance4.Translate(sentence, LeetMe.LeetLevel.Leet);
        }

        [Benchmark]
        public string LeetDicoCharArray()
        {
            return LeetMeInstance2.Translate(sentence, LeetMe.LeetLevel.Leet);
        }

        [Benchmark]
        public string LeetDicoCharList()
        {
            return LeetMeInstance3.Translate(sentence, LeetMe.LeetLevel.Leet);
        }
    }

    [CoreJob]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchRoxxor
    {
        private readonly string sentence;

        private readonly LeetMe.Leet LeetMeInstance1 = new LeetMe.Leet();
        private readonly LeetMe.Leet2 LeetMeInstance2 = new LeetMe.Leet2();
        private readonly LeetMe.LeetMe3 LeetMeInstance3 = new LeetMe.LeetMe3();
        private readonly LeetMe.LeetMe4 LeetMeInstance4 = new LeetMe.LeetMe4();

        public BenchRoxxor()
        {
            sentence = LoremNET.Lorem.Sentence(5, 10);
        }

        [Benchmark]
        public string RoxxorArrayInline()
        {
            return LeetMeInstance1.Translate(sentence, LeetMe.LeetLevel.Roxxor);
        }

        [Benchmark]
        public string RoxxorArrayDefined()
        {
            return LeetMeInstance4.Translate(sentence, LeetMe.LeetLevel.Roxxor);
        }

        [Benchmark]
        public string RoxxorDicoCharArray()
        {
            return LeetMeInstance2.Translate(sentence, LeetMe.LeetLevel.Roxxor);
        }

        [Benchmark]
        public string RoxxorDicoCharList()
        {
            return LeetMeInstance3.Translate(sentence, LeetMe.LeetLevel.Roxxor);
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
