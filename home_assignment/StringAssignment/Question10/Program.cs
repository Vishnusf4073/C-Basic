using System;
namespace String10;
class Program 
{
    public static void Main()
    {
       string username, password;
       int ctr = 0;
        do
        {
			Console.Write("Enter the username: ");
			username = Console.ReadLine();
 
			Console.Write("Enter the password: ");
			password = Console.ReadLine();
			
             if(username != "vishnu" || password != "9981")
             ctr++;
             else
             ctr=1;
     
        }
        while((username != "vishnu" || password != "9981")  && (ctr != 3));
	 
        if (ctr == 3)
            Console.Write("\nLogin attemp three or more times. Try later!\n");
        else   
            Console.Write("\nThe password entered successfully!\n");		
    }
}
