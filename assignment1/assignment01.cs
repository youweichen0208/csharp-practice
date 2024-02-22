/*
 *  Practice number sizes and ranges
 */
// 1. outputs the number of bytes in memory that each of the following number types uses, and the
// minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
// ulong, float, double, and decimal.
using System.Text.RegularExpressions;

void UnderstandingTypes()
{
    Console.WriteLine("sbyte: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(sbyte),
        sbyte.MinValue, sbyte.MaxValue);
    Console.WriteLine("byte: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(byte),
        byte.MinValue, byte.MaxValue);
    Console.WriteLine("short: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(short),
        short.MinValue, short.MaxValue);
    Console.WriteLine("ushort: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(ushort),
        ushort.MinValue, ushort.MaxValue);
    Console.WriteLine("int: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(int),
        int.MinValue, int.MaxValue);
    Console.WriteLine("uint: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(uint),
        uint.MinValue, uint.MaxValue);
    Console.WriteLine("long: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(long),
        long.MinValue, long.MaxValue);
    Console.WriteLine("ulong: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(ulong),
        ulong.MinValue, ulong.MaxValue);
    Console.WriteLine("float: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(float),
        float.MinValue, float.MaxValue);
    Console.WriteLine("double: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}", sizeof(double),
        double.MinValue, double.MaxValue);
    Console.WriteLine("decimal: number of bytes in memory = {0} bytes, min value = {1}, max value = {2}",
        sizeof(decimal),
        decimal.MinValue, decimal.MaxValue);
}
//uncomment below to run the answer:
// UnderstandingTypes();



/*
 * 2. Write program to enter an integer number of centuries and convert it to years, days, hours,
   minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
   type for every data conversion. Beware of overflows!
 */
void TimeConversion(int century)
{
    long year = century * 100;
    var day = year * 365.25;
    var hours = day * 24;
    var minutes = hours * 60;
    var seconds = minutes * 60;
    var milliseconds = seconds * 1000;
    var microseconds = milliseconds * 1000;
    var nanoseconds = microseconds * 1000;
    Console.WriteLine(
        "{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
        century, year, day, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
}
//uncomment below to run the answer:
// it supports to enter any number in the century parameter
// TimeConversion(1);



// Practice loops and operators
// 1. FizzBuzz
string FizzBuzz()
{
    var result = "";
    for (var i = 1; i <= 100; i++)
        if (i % 3 == 0 && i % 5 == 0)
            result += "/fizzbuzz";
        else if (i % 3 == 0)
            result += "/fizz";
        else if (i % 5 == 0)
            result += "/buzz";
        else
            result += "/" + i;

    return result;
}
//uncomment below to run the answer:
// Console.WriteLine(FizzBuzz());


// 2. Print-a-Pyramid.
void PrintPyramid(int levels)
{
    for (var i = 0; i < levels; i++)
    {
        var row = "";
        for (var j = levels; j >= i; j--) row += " ";

        for (var j = 0; j < i * 2 + 1; j++) row += "*";

        Console.WriteLine(row);
    }
}
//uncomment below to run the answer:
// PrintPyramid(5);



// 3. Our program can create a random number between 1 and 3 with the following code:
void GuessNumber()
{
    var correctNumber = new Random().Next(3) + 1;
    Console.Write("Enter a number and take a guess: ");
    var guessedNumber = int.Parse(Console.ReadLine());
    if (guessedNumber < 1 || guessedNumber > 3)
        Console.WriteLine("Your guess is outside of the range!");
    else if (guessedNumber < correctNumber)
        Console.WriteLine("Your guess is lower than the correct number.");
    else if (guessedNumber > correctNumber)
        Console.WriteLine("Your guess is higher than the correct number");
    else
        Console.WriteLine("Congratulations! You get the correct number!");
}
//uncomment below to run the answer:
// GuessNumber();



// 4. Write a simple program that defines a variable representing a birth date and calculates
// how many days old the person with that birth date is currently.
void Birthdate(int year, int month, int day)
{
    var birthDate = new DateTime(year, month, day);
    var currentDays = DateTime.Now.Day - birthDate.Day;
    Console.WriteLine("The person is {0} days old with that birth date.", currentDays);

    var daysToNextAnniversary = 10000 - currentDays % 10000;
    var next = DateTime.Now.AddDays(daysToNextAnniversary);
    Console.WriteLine("The date of next 10,000 day anniversary is on {0}-{1}-{2}.", next.Year, next.Month, next.Day);
}
//uncomment below to run the answer:
// Birthdate(2001, 5, 20);



// 5. Write a program that greets the user using the appropriate greeting for the time of day.
void Greeting()
{
    var hour = DateTime.Now.Hour;
    if (hour <= 12 && hour > 6) Console.WriteLine("Good Morning");

    if (hour > 12 && hour <= 19) Console.WriteLine("Good Afternoon");

    if (hour > 19 && hour <= 24) Console.WriteLine("Good Evening");

    if (hour > 0 && hour <= 6) Console.WriteLine("Good Night");
}
//uncomment below to run the answer:
//Greeting();



// 6. Write a program that prints the result of counting up to 24 using four different increments.
void CountTo24()
{
    for (var i = 1; i <= 4; i++)
    {
        var line = "";
        for (var j = 0; j <= 24; j += i)
            if (j == 24)
                line += j;
            else
                line += j + ",";
        Console.WriteLine(line);
    }
}
//uncomment below to run the answer:
//CountTo24();



// Practice Arrays:
// 1. Copying an Array
void CopyArray()
{
    string[] arr1 =
        { "Apple", "Banana", "Orange", "Mango", "Strawberry", "Watermelon", "Grape", "Pineapple", "Cherry", "Peach" };
    var arr2 = new string[arr1.Length];
    for (var i = 0; i < arr1.Length; i++) arr2[i] = arr1[i];

    Console.Write("original array content: ");
    for (var i = 0; i < arr1.Length; i++) Console.Write(arr1[i] + " ");
    Console.WriteLine();
    Console.Write("copied array content: ");
    for (var i = 0; i < arr2.Length; i++) Console.Write(arr2[i] + " ");
    Console.WriteLine();
}
//uncomment below to run the answer:
//CopyArray();



// 2. Write a simple program that lets the user manage a list of elements.
void TodoList()
{
    List<string> list = new List<string>();
    while (true)
    {
        Console.WriteLine("Enter command (+item_name, -item_name, -- to clear, or exit to exit)):");
        string input = Console.ReadLine();
        if (input.StartsWith("+"))
        {
            string[] split = input.Split("+");
            list.Add(split[1]);
        }
        else if (input.StartsWith("-"))
        {
            string[] split = input.Split("-");
            list.Remove(split[1]);
        } else if (input == "--")
        {
            list.Clear();
        }
        else
        {
            break;
        }

        foreach (string element in list)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }   
}
//uncomment below to run the answer:
// TodoList();


// 3. Write a method that calculates all prime numbers in given range and returns them as array
// of integers
static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> list = new List<int>();
    for (int i = startNum; i <= endNum; i++)
    {
        if (i == 2)
        {
            list.Add(i);
            continue;
        }
        if (i == 1 || i % 2 == 0)
            continue;
        int sqrtVal = (int)Math.Floor(Math.Sqrt(i));
        bool checkPrime = true;
        for (int j = 3; j <= sqrtVal; j++)
        {
            if (i % j == 0)
            {
                checkPrime = false;
                break;
            }
        }

        if (checkPrime)
        {
            list.Add(i);
        }
    }

    return list.ToArray();
}
// Below is the code to iterate through the array and print out the prime numbers
//uncomment below to run the answer:
// int startIndex = 1;
// int endIndex = 10;
// foreach (int element in FindPrimesInRange(startIndex, endIndex))
// {
//     Console.WriteLine(element);
// }


// 4.Write a program to read an array of n integers (space separated on a single line) and an
// integer k, rotate the array right k times and sum the obtained arrays after each rotation as
// shown below.
int[] CalculateRotations(int[] input, int k)
{
    int[] sum = new int[input.Length];
    for (int i = 1; i <= k; i++)
    {
        for (int j = 0; j < input.Length; j++)
        {
            int index = (j + i) % (input.Length);
            sum[index] += input[j];
        }
    }

    return sum;
}

// Below is the code to iterate through the array and print out the sum[] result
// uncomment below to run the answer:
// int[] input = { 1, 2, 3, 4, 5 };
// int k = 3;
// foreach (var elem in CalculateRotations(input, k))
// {
//     Console.Write(elem + " ");
// }


// 5. Write a program that finds the longest sequence of equal elements in an array of integers.
// If several longest sequences exist, print the leftmost one.
string FindLongestSequence(int[] input)
{
    string result = "";
    int longestLength = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int index = i + 1;
        int length = 1;
        string temp = input[i].ToString() + " ";
        while (index < input.Length)
        {
            if (input[index] == input[i])
            {
                temp += input[index] + " ";
                index++;
                length++;
            }
            else
                break;
        }

        if (length > longestLength)
        {
            result = temp;
            longestLength = length;
        }
    }

    return result;
}
// uncomment below to run the answer:
// int[] input1 = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
// int[] input2 = { 1, 1, 1, 2, 3, 1, 3, 3 };
// int[] input3 = { 4, 4, 4, 4 };
// int[] input4 = { 0, 1, 1, 5, 2, 2, 6, 3, 3 };
// Console.WriteLine(FindLongestSequence(input4));

// 6. Write a program that finds the most frequent number in a given sequence of numbers. In
// case of multiple numbers with the same maximal frequency, print the leftmost of them
void FindMostFrequentNumber(int[] input)
{
    Dictionary<int, int> table = new Dictionary<int, int>();
    
    int count = 0;
    int result = 0;
    foreach (int num in input)
    {
        if (table.ContainsKey(num))
        {
            table[num] = table[num] + 1;
        }
        else
        {
            table[num] = 1;
        }

        if (table[num] > count)
        {
            count = table[num];
            result = num;
        } 
    }
    Console.WriteLine("Most frequent number in a given sequence is {0}", result);
}
// uncomment below to run the answer:
// int[] test1 = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
// int[] test2 = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
// FindMostFrequentNumber(test2);

// Practice Strings:
// 1. Write a program that reads a string from the console, reverses its letters and prints the
// result back at the console.
void ReverseString()
{
    Console.Write("Please Enter the string: ");
    String input = Console.ReadLine();
    char[] arr = input.ToCharArray();
    Array.Reverse(arr);
    foreach (char elem in arr)
    {
        Console.Write(elem);
    }
}
// uncomment below to run the answer:
// ReverseString();

// 2. Write a program that reverses the words in a given sentence without changing the
// punctuation and spaces
void ReverseSentence(string input)
{ 
    char[] arr = input.ToCharArray();
   Array.Reverse(arr);
   string result = new string(arr);
   Console.WriteLine(result);
}
//uncomment below to run the answer:
//ReverseSentence("C# is not C++, and PHP is not Delphi!");


// 3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
// and prints thddem on the console on a single line, separated by comma and space.Print all
// unique palindromes (no duplicates), sorted
void PrintPalindromes(string input)
{
    List<string> palindromes = ExtractPalindromes(input);
    palindromes.Sort();
    Console.WriteLine(string.Join(", ", palindromes)); 
}
List<string> ExtractPalindromes(string input)
{
    string[] words = Regex.Split(input, @"[\s.,:;=()\[\]""'\\/!?]+");
    List<string> palindromes = new List<string>();
    foreach (string word in words)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversedWord = new string(charArray);
        if (word == reversedWord)
        {
            palindromes.Add(word);
        }
    }

    return palindromes;
}
// uncomment below to run the answer:
//PrintPalindromes("Hi,exe? ABBA! Hog fully a string: ExE. Bob");



// 4.Write a program that parses an URL given in the following format:
// [protocol]://[server]/[resource]
void ParseURL(string url)
{
    string protocol = "";
    string server = "";
    string resource = "";
    if (url.Contains("://"))
    {
        string[] prt1 = url.Split("://");
        protocol = prt1[0];
        if (prt1[1].Contains("/"))
        {
            string[] prt2 = url.Split("/");
            server = prt2[0];
            resource = prt2[1];
        }
        else
        {
            server = prt1[1];
        }
    }
    else if (url.Contains("/"))
    {
        string[] prt1 = url.Split("/");
        server = prt1[0];
        resource = prt1[1];
    }
    else
    {
        server = url;
    }
    Console.WriteLine("[protocol] = \"{0}\"", protocol);
    Console.WriteLine("[server] = \"{0}\"", server);
    Console.WriteLine("[resource] = \"{0}\"", resource);
}
// uncomment below to run the answer:
// ParseURL("www.apple.com");


