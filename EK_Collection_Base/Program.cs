using EK_Collection_Base.Configurations;
using EK_Collection_Base.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EK_Collection_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintConsoleVerticalMessage("Hello world!");
            ArraySampleFunction();
            ListSampleFunction();

            Console.ReadKey();
        }

        public static void GenericDictionariesSampleFunction()
        {
            var states = new Dictionary<string, string>
            {
                { "CA", "California" },
                { "WA", "Washington" },
                { "NY", "New York" }
            };
        }

        public static void ListSampleFunction()
        {
            var colorOptions = new List<string>() {
                "Red", "Espresso", "White", "Navy"
            };

            colorOptions.Insert(2, "Purple");
            colorOptions.Remove("White");

            PrintConsoleTopicHeader("List sample function started..");

            colorOptions.ForEach(c => Console.WriteLine(c));

            PrintConsoleTopicHeader("Sample list function finished");
        }

        public static void ArraySampleFunction()
        {
            string[] colorOptions = { "Red", "Green", "Blue" };
            var colorGreenIndex = Array.IndexOf(colorOptions, "Green");
            colorOptions.SetValue("Purple", 2);

            PrintConsoleTopicHeader("Array sample function started..");

            foreach (var color in colorOptions)
            {
                Console.WriteLine(color.ToUpper());
            }

            for (int i = 0; i < colorOptions.Length; i++)
            {
                Console.WriteLine(colorOptions[i].ToLower());
            }

            PrintConsoleTopicHeader("Sample array function finished");
        }

        public static void PrintConsoleTopicHeader(string header, SeparationLineType type = SeparationLineType.Header)
        {
            var separationLine = type==SeparationLineType.Header?
                                    "\n\r--------------------------------------\n\r":
                                    "\n\r--------------------------------------\n\r";

            var text = ShortenLineLength(header, 50);

            text = String.Concat(separationLine, text, separationLine);

            Console.WriteLine(text);
        }

        public static string ShortenLineLengthForEachParagraph(string origMsg, int maxLineLength)
        {
            StringBuilder sb = new StringBuilder();
            string[] paragraphs = origMsg.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (var paragraph in paragraphs)
            {
                sb.AppendLine(ShortenLineLength(paragraph, maxLineLength));
            }
            return sb.ToString();
        }

        private static string ShortenLineLength(string origMsg, int maxLineLength)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = origMsg.Split(' ');
            int currLineLength = 0;

            foreach(string word in words)
            {
                if (word.Length + 1 > maxLineLength)
                    return sb.Append("[Error]: Provided message has a bigger length word than the provided max line length").ToString();
            }

            foreach (string word in words)
            {
                if (currLineLength + word.Length + 1 < maxLineLength) // +1 accounts for adding a space
                {
                    if (currLineLength == 0)
                    {
                        sb.Append(word);
                        currLineLength = currLineLength + word.Length;
                    }
                    else
                    {
                        sb.Append(" " + word);
                        currLineLength = currLineLength + word.Length + 1; // +1 accounts for adding a space
                    }

                }
                else
                {
                    sb.AppendFormat("{0}{1}", Environment.NewLine, word);
                    currLineLength = word.Length;
                }
            }
            return sb.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        private static void PrintConsoleVerticalMessage(string message)
        {
            if (String.IsNullOrEmpty(message))
                return;

            char[] letters = message.ToCharArray();

            foreach(var letter in letters)
                Console.WriteLine(letter);
        }
    }
}
