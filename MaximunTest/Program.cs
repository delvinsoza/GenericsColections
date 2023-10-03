Console.WriteLine($"Maximun of 3, 4, 5,{Maximum(3, 4, 5)}\n");
Console.WriteLine($"Maximun of 6.6, 8.8 abd 7.7 is{Maximum(3, 4, 5)}\n");
Console.WriteLine($"Maximun of pear, apple and orange is :" +
    $"{Maximum("pear", "apple", "orange")}\n");


//generic funcion determine the largest of the Icomparable
T Maximum<T>(T x,T  y,T  z) where T : IComparable<T>
{
    var max = x; // assume x is initialy the largest 

    if (y.CompareTo(max) > 0)
    {
        max = y; // is the largest so far
    }
    // comparey whitc max
    if(z.CompareTo(max) > 0)
    {
        max = z; // z is the largest
    }
    return max;
}