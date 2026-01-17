using System;
using System.IO;
class Program
{
    static void Main()
    {
        Console.WriteLine("my name is muzamil ");// it only read the  line that is written in the stings 
        Main1();
    }
    static void Main1()
    {
        Console.WriteLine("right your name ");

        string? username = Console.ReadLine();

        Console.WriteLine("my name is {0}", username);
        Main2();
    }

    static void Main2()
    {
        Console.WriteLine("right your name ");

        string? username = Console.ReadLine();

        Console.WriteLine("shah " + username);
        Main3();
    }
    static void Main3()
    {
        Console.WriteLine("write ist name ");

        string? istname = Console.ReadLine();

        Console.WriteLine("write ist name ");

        string? lastname = Console.ReadLine();

        Console.WriteLine("hello {0},{1}", istname, lastname);

    }
{
    static void Main()
    {
        Console.WriteLine("enter first number ");

        Console.ReadLine();
    }
}

// aaaaaaaaaa