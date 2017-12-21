using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PossibleSubStrings
    {
        public PossibleSubStrings()
        {
            //string str = "PanknaP";
            string str = "Pankaj";
            var data = from i in Enumerable.Range(0, str.Length)
                       from j in Enumerable.Range(0, str.Length - i + 1)
                       where j >= 1
                       select str.Substring(i, j);

            //int[] arr = new int[] { 3, 6, 8, 5, 0, 1 };
            //int[] arr2 = new int[5];
            //Array.Copy(arr, arr2, 5);
            //Array.Reverse(arr2);
            //Array.Copy(arr2, arr, 5);
            foreach (var item in data.ToArray())
            {
                Console.WriteLine(item);
            }

            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 1; j + i <= str.Length; j++)
                {
                    result += "," + str.Substring(i, j);
                }
            }
            foreach (var item in result.Split(','))
            {
                Console.WriteLine(item);
            }

        }

    }
}
