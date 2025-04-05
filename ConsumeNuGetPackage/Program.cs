using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        string testString = "Hello, World!";
        bool startsWithUpper = testString.StartsWithUpper();  
        Console.WriteLine($"Here is the input: {testString}" + $"\nStarts with uppercase: {startsWithUpper}");

        string testString2 = "hello, World!";
        bool startsWithUpper2 = testString2.StartsWithUpper();
        Console.WriteLine($"Here is the input: {testString2}" + $"\nStarts with uppercase: {startsWithUpper2}");
    }
}