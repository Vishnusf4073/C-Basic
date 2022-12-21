using System;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the nameone: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the nametwo: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Nameone: " + name1 + "     Nametwo: " + name2);
             test(name1, name2);

         void test(string str1, string str2)
           {
            string text1 = String.Concat(str1.ToUpper().OrderBy(c => c));
            string text2 = String.Concat(str2.ToUpper().OrderBy(c => c));
            
            if (text1 == text2)
                {
                    Console.WriteLine(" Name one and two are Anagrams");
                }
                else
                {
                    Console.WriteLine(" Name one and two are not Anagrams");
                }

            }

        }
    }
}
