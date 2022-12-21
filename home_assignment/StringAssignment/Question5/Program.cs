using System;  
public class Exercise6
{  
    public static void Main() 
{
    string str1, str2;
    int c=0;
	int i=0,l1,l2,yn=0;
	
      
      Console.Write("Input the 1st string : ");
      str1 = Console.ReadLine();	   
	   
      Console.Write("Input the 2nd string : ");
      str2 = Console.ReadLine();	   

	  l1=str1.Length;
	  l2=str2.Length;
 
if(l1==l2)
  {
    for(i=0;i<l1;i++)
     {
        if(str1[i] != str2[i])
          {
            yn=1;
            i=l1;
           
          }
     }
  }

    if(l1 == l2)
        c=0;
    else if(l1 > l2)
        c=1;
    else if(l1 < l2)
        c=-1;
  
    if(c == 0)
    {
       if(yn==0)
       Console.Write("\nThe length of both strings are equal and \nalso, both strings are same.\n\n");
       else
            Console.Write("\nThe length of both strings are equal \nbut they are not same.\n\n");
    }
    else if(c == 1)
    {
       Console.Write("\nThe length of the both string are not equal.\n\n");
    }
    else
    {
       Console.Write("\nThe length of the both string is not equal.\n\n");
    }
	}
}
