using System;
using Task_1_18._08._2022.Models;

namespace Task_1_18._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExtensionMethods.isOdd(10));
            Console.WriteLine(ExtensionMethods.isEven(8));
            Console.WriteLine(ExtensionMethods.isContainsDigit("Jhskaix9382nsk"));
            Console.WriteLine(ExtensionMethods.toCapitalize("hjOhjKnfFfFghHHjkk"));
            foreach (var item in ExtensionMethods.GetValueIndexes("This method searches the string for a certain character", 'a'))
            {
                Console.WriteLine(item);
            }
        }
    }
}
