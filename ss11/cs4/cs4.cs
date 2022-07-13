using System;
using System.Collections.Generic;

class SwapNumbers
{
    static void Swap<T> (ref T valOne, ref T valTwo)
    {
        T temp = valOne;
        valOne = valTwo;
        valTwo = temp;
    }
    static void Main(string[] args)
    {
        int numOne = 23;
        int numTwo = 45;
        Console.WriteLine("Values before swapping: " + numOne + " & " + numTwo);
        Swap(ref numOne, ref numTwo);
        Console.WriteLine("Values after swapping: " + numOne + " & " + numTwo);

    }
}
