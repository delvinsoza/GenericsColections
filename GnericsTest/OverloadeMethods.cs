using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnericsTest
{
    public class OverloadeMethods
    {
        public static void DisplayeArray(int[] inputSArray)
        {
            foreach(var item in inputSArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public static void DisplayeArray(double[] inputSArray)
        {
            foreach (var item in inputSArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public static void DisplayeArray(char[] inputSArray)
        {
            foreach (var item in inputSArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

}
