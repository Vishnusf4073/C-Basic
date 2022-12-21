using System;
namespace StringAss;
class Program
{
    static void Main(string[] args)
    {
        string str1;
       
        Console.Write("Input the string: ");
        str1 = Console.ReadLine();
        Console.Write("The Character of  the string are: ");
        foreach(var chr in str1)
        {
            Console.Write(chr+" ");
        }
    }
}

