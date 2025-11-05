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





////Task 4

//using System;

//class Program
//{
//    static void Main()
//    {

//        int[] favoriteNumbers = { 7, 3, 9, 1, 5 };


//        Array.Sort(favoriteNumbers);
//        Console.WriteLine("Array after sorting (ascending):");
//        for (int i = 0; i < favoriteNumbers.Length; i++)
//        {
//            Console.WriteLine(favoriteNumbers[i]);
//        }


//        Array.Reverse(favoriteNumbers);
//        Console.WriteLine("\nArray after reversing:");
//        for (int i = 0; i < favoriteNumbers.Length; i++)
//        {
//            Console.WriteLine(favoriteNumbers[i]);
//        }


//        int searchNumber = 5;
//        int index = Array.IndexOf(favoriteNumbers, searchNumber);
//        if (index != -1)
//        {
//            Console.WriteLine($"\nNumber {searchNumber} found at index {index} in the array.");
//        }
//        else
//        {
//            Console.WriteLine($"\nNumber {searchNumber} not found in the array.");
//        }
//    }
//}





////Task 5

//using System;

//class Program
//{
//    static void Main()
//    {

//        DateTime birthDate = new DateTime(2000, 5, 10); 


//        DateTime currentDate = DateTime.Now;


//        TimeSpan ageSpan = currentDate - birthDate;
//        int ageInYears = (int)(ageSpan.TotalDays / 365.25); 


//        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
//        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
//        Console.WriteLine($"Age: {ageInYears} years");


//        DateTime newDate = birthDate.AddDays(10);
//        Console.WriteLine($"Birthdate after adding 10 days: {newDate.ToShortDateString()}");
//    }
//}





////Task 6

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
        
//        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

        
//        fruits.Add("Orange");

        
//        fruits.Remove("Banana");

      
//        Console.WriteLine("Fruits in the list:");
//        foreach (string fruit in fruits)
//        {
//            Console.WriteLine(fruit);
//        }

        
//        Dictionary<int, string> fruitDict = new Dictionary<int, string>
//        {
//            {1, "Apple"},
//            {2, "Banana"},
//            {3, "Mango"}
//        };

        
//        fruitDict.Add(4, "Orange");

        
//        Console.WriteLine("\nFruits in the dictionary:");
//        foreach (KeyValuePair<int, string> kvp in fruitDict)
//        {
//            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
//        }
//    }
//}







