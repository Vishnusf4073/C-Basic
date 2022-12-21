using System;
namespace Method;
    class Program
    {
        public static void Main (string[] args)
        {
                string str1= "Welcome Friends!"; 
                string str2="Have a nice day!";
                Console.Write(prints(str1,str2));
            string prints(string str1,string str2)
                {
                    return(str1+"\n"+str2);
                }
           
            }     
        }
    