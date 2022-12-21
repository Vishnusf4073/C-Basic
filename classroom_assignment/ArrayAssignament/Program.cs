using System;
namespace ArrayAssignment;
class Program
{
    public static void Main (string[] args)
    {
        string [] arr = new string[5];
        int count=0;
        int index_no=0;

        for (int i=0; i<5;i++)
        {
            Console.WriteLine($"Enter the {i+1} name: ");
            arr[i]=Console.ReadLine();
        }

        for (int i=0; i<5;i++)
        {
            Console.WriteLine($"Name at  {i} index is:\t"+arr[i]);
            //Console.WriteLine();
        }
        
        Console.WriteLine($"Enter the  name you want to search: ");
        string name = Console.ReadLine();
//For
        for (int i=0; i<5;i++)
        {
            if(arr[i]==name)
            {
                count++;
                index_no=i;
            }
            
        }
        
        if(count>=1)
        Console.WriteLine($"Name:-{name} is present at index NO:\t"+index_no);
        else
        Console.WriteLine("The name is not present in array");
//ForEach
        foreach(string str in arr)
        {
            if(str==name)
            {
                count++;
            }
        }
        if(count>=1)
        Console.WriteLine("The name is present in array\n");
        else
        Console.WriteLine("The name is not present in array\n");
    }
}