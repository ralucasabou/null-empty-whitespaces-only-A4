using System;

namespace null_empty_whitespaces_only_A4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ReadFromKeyboard("Text=") ??
                          ReadFromKeyboard("Text (2nd attempt)=") ??
                          ReadFromKeyboard("Text (3nd attempt)=") ??
                          "nu am continut";

            Console.WriteLine(text);
        }

        static string ReadFromKeyboard(string label)
        {
            Console.Write(label);
            string text = Console.ReadLine();

            return string.IsNullOrWhiteSpace(text)
                    ? null
                    : text;
        }
    }
}

