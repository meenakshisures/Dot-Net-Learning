using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MeenakshiDemoApp
{
    class WordSummarizing
    {
        static void Main(string[] args)
        {
            LiftHandler.Lift();
        }
        static void YY(){
            Types types = new Types();
            types.Array();
            Console.WriteLine("Hello World!");

            var sentence = "This is a very very very very very veryv very very very very very looooong loon loong loooong";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

            var result = StringBuilderUtility.BuildString();
            Console.WriteLine(result);

            Console.WriteLine("What is your name");
            var name = Console.ReadLine();
            var reversed = ProceduralProgramming.ReverseName(name);
            Console.WriteLine("Reversed name:" + reversed);

            var debugging = Debuging.DebugingNumbers();
            Console.WriteLine(debugging);

            // New functionalities
            Console.WriteLine("\nFile Operations:");
            Console.Write("Enter the file path to process: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                int wordCount = FileUtilities.CountWords(filePath);
                Console.WriteLine($"Number of words in the file: {wordCount}");

                string longestWord = FileUtilities.FindLongestWord(filePath);
                Console.WriteLine($"Longest word in the file: {longestWord}");
            }
            else
            {
                Console.WriteLine("The file does not exist. Please check the path.");
            }
        }
    }

    class StringBuilderUtility
    {
        public static string BuildString()
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            return builder.ToString(); // Ensure this line always executes
        }
    }

    class ProceduralProgramming
    {
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            var reversed = new string(array);
            return reversed;
        }
    }

    class Debuging
    {
        public static string DebugingNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallestsList(numbers, 3);
            var result = string.Join(", ", smallests); // Combine numbers into a string for returning
            Console.WriteLine($"Smallest numbers: {result}");
            return result;
        }

        public static List<int> GetSmallestsList(List<int> list, int count)
        {
            var smallestsList = new List<int>();
            while (smallestsList.Count < count)
            {
                var min = GetMin(list);
                smallestsList.Add(min);
                list.Remove(min);
            }
            return smallestsList;
        }

        public static int GetMin(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }

    class FileUtilities
    {
        // Method to count words in a file
        public static int CountWords(string filePath)
        {
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Method to find the longest word in a file
        public static string FindLongestWord(string filePath)
        {
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = "";
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }
            return longestWord;
        }
    }
    class LiftHandler
    {
        // Method to count words in a file
        public static void Lift(int countLift = 4)
        {
            string[] numbers = new string[countLift];
            Array.Fill(numbers, null); // Initialize lifts with null
            int currentUser = 0;

            while (true)
            {
                Console.WriteLine("Enter a character (or 'x' to exit):");
                var input = Console.ReadLine();

                if (input.ToLower() == "x")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                var index = currentUser % countLift; // Circular logic
                Console.WriteLine($"The user {input} is in lift {index}");
                numbers[index] = input; // Store input in the lift array

                Console.WriteLine($"Lift allocation: [{string.Join(", ", numbers)}]");
                currentUser++;
            }
        }


    }

}
