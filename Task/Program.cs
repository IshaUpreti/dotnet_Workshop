////Task 1

//using System;

//class Program
//{
//    static void Main()
//    {

//        string userName = "Isha";
//        int luckyNumber = 7;


//        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
//    }
//}




////Task 2
//using System;

//class Circle
//{

//    public const double PI = 3.14;


//    public static double CalculateArea(double radius)
//    {
//        return PI * radius * radius;
//    }


//    public static double CalculatePerimeter(double radius)
//    {
//        return 2 * PI * radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        double radius = 5;



//        Console.WriteLine($"PI value: {Circle.PI}");
//        Console.WriteLine($"Area of circle with radius {radius}: {Circle.CalculateArea(radius)}");
//        Console.WriteLine($"Perimeter of circle with radius {radius}: {Circle.CalculatePerimeter(radius)}");
//    }
//}






////Task 3

//using System;

//class Program
//{
//    static void Main()
//    {

//        byte myByte = 255;
//        short myShort = 32000;
//        int myInt = 42;
//        long myLong = 1234567890;
//        float myFloat = 3.14f;
//        double myDouble = 3.14159;
//        decimal myDecimal = 9.99m;
//        char myChar = 'A';
//        bool myBool = true;


//        string intToString = myInt.ToString();         
//        double stringToDouble = Convert.ToDouble("3.14"); 


//        Console.WriteLine($"byte: {myByte}");
//        Console.WriteLine($"short: {myShort}");
//        Console.WriteLine($"int: {myInt}");
//        Console.WriteLine($"long: {myLong}");
//        Console.WriteLine($"float: {myFloat}");
//        Console.WriteLine($"double: {myDouble}");
//        Console.WriteLine($"decimal: {myDecimal}");
//        Console.WriteLine($"char: {myChar}");
//        Console.WriteLine($"bool: {myBool}");
//        Console.WriteLine($"int to string: {intToString}");
//        Console.WriteLine($"string to double: {stringToDouble}");
//    }
//}





//Task 4

using System;

class Program
{
    static void Main()
    {
        
        int[] favoriteNumbers = { 7, 3, 9, 1, 5 };

        
        Array.Sort(favoriteNumbers);
        Console.WriteLine("Array after sorting (ascending):");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

       
        Array.Reverse(favoriteNumbers);
        Console.WriteLine("\nArray after reversing:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        
        int searchNumber = 5;
        int index = Array.IndexOf(favoriteNumbers, searchNumber);
        if (index != -1)
        {
            Console.WriteLine($"\nNumber {searchNumber} found at index {index} in the array.");
        }
        else
        {
            Console.WriteLine($"\nNumber {searchNumber} not found in the array.");
        }
    }
}




