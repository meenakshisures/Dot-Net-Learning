using System;

namespace MeenakshiDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Types types = new Types();
            types.Array();
            Console.WriteLine("Hello World!");

            var sentence = "This is a very very very very very veryv very very very very very looooong loon loong loooong";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

        }
    }

}
