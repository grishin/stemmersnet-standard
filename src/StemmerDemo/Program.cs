using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iveonik.Stemmers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TestStemmer(new RussianStemmer(), "краcОта", "красоту", "красоте", "КрАсОтОй", "василия", "альфабанку");
            TestStemmer(new EnglishStemmer(), "jump", "jumping", "jumps", "jumped");
            TestStemmer(new GermanStemmer(), "mochte", "mochtest", "mochten", "mochtet");
            Console.ReadKey();
        }

        private static void TestStemmer(IStemmer stemmer, params string[] words)
        {
            Console.WriteLine("Stemmer: " + stemmer);
            foreach (string word in words)
            {
                Console.WriteLine(word + " --> " + stemmer.Stem(word));
            }
        }
    }
}
