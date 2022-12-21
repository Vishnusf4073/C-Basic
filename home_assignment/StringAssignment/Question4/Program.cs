using System;  
namespace String;
public class String4
{  
    public static void Main() 
{
    string str;
    int  wrd=1,l=0;
    
      Console.Write("Input the string : ");
      str = Console.ReadLine();
    while (l <= str.Length - 1)
    {
        if(str[l]==' ' || str[l]=='\n' || str[l]=='\t')
        {
            wrd++;
        }

        l++;
    }

   Console.Write("\nTotal number of words in the string is : {0}\n", wrd);
	}
}
