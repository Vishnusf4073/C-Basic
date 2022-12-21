using System;
namespace StringAss;
class Pprogram
{
    static void Main(string[] args)
    {
        string str1;
        
        int strt = 0;
        int cnt = -1;
        int idx = -1;

        Console.Write("Input the string: ");
        str1 = Console.ReadLine();
        Console.WriteLine("input the sub string You want to search: ");
        string sub_string=Console.ReadLine().ToLower();
        while (strt !=-1)
        {
            strt = str1.IndexOf(sub_string,idx+1);
            cnt+=1;
            idx = strt;
        }
        Console.Write("The sub string occuers "+ cnt +" Times");
    }
}

