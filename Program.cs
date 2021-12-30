﻿using System;
using System.Text;

namespace ReversingString
{
    class Program
    {

        static String ReverseEachWord(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            String[] arr = input.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse(arr[i]));
                if (i != arr.Length - 1)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }

        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Akshay Pathak"));
            Console.WriteLine(ReverseEachWord("How are you"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("C# is Tough :)"));
            Console.ReadLine();
        }
    }
}