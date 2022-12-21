using System;  
public class Exercise7  
{  
    public static void Main() 
{
    string str;
    int alp=0, digit=0, spl=0, i=0,l;
      Console.Write("Enter Input the string : ");
      str = Console.ReadLine();	
      l=str.Length; 


    while(i<l)
    {
        if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
        {
            alp++;
        }
        else if(str[i]>='0' && str[i]<='9')
        {
            digit++;
        }
        else
        {
            spl++;
        }

        i++;
    }

   Console.Write("Number of Alphabets in the string is : {0}\n", alp);
   Console.Write("Number of Digits in the string is : {0}\n", digit);
   Console.Write("Number of Special characters in the string is : {0}\n\n", spl);
	}
}
