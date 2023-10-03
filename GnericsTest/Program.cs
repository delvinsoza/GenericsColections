// create arrays of int, doubles and char
using GnericsTest;

int[] intArray = {1, 2, 3, 4, 5, 6 };
double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
char[] charArray = { 'H', 'u',  };

Console.WriteLine("Array intArray contains");
OverloadeMethods.DisplayeArray(intArray);
Console.WriteLine("Array intArray contains");
OverloadeMethods.DisplayeArray(intArray);
Console.WriteLine("Array intArray contains");
OverloadeMethods.DisplayeArray(intArray);

void DisplayArray<T>(T[] inputArray)
{
    foreach(var item in inputArray)
    {
        Console.WriteLine(item);
    }

}