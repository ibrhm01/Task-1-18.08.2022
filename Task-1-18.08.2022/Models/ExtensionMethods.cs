using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_18._08._2022.Models
{
    class ExtensionMethods
    {
        private static int[] _indexes;
        public static bool isOdd(int num)
        {
            if (num % 2 != 0) return true;
            return false;
        }
        public static bool isEven(int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }
        public static bool isContainsDigit(string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item)) return true;
            }
            return false;
        }
        public static string toCapitalize(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str.ToUpper());
            return sb.ToString();

        }

        public static int[] GetValueIndexes(string str, char a)
        {
            int index = 0;
            int[] arr = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == a)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[index] = i;
                    index++;
                    
                }
                    
            }
            return arr;
        }
    }
}
