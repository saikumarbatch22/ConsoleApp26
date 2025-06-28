using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    /*
     * Switch: It is also a conditional branching
     * It has case and break statements and followed 
     * by default if none of the cases executes then it will go
     * to default case.
     * 
     * syntax:
     * switch(expression)
     * {
     * case '':
     *  statements;
     *  break;
     *  case '':
     *  statements;
     *  break;
     *  case '':
     *  statements;
     *  break;
     *  ....
     *  
     *  default:
     *  statements;
     *  break;
     *  
     *  break is jump statement but in switch case it is used to 
     *  terminate the given statement.
     *  
     *  switch statement directly switches to the particular statement 
     *  rather than checking each and every statement.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char s=Convert.ToChar(Console.ReadLine());
            switch(s)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("Entered character is a vowel");
                    break;
                case 'e':
                case 'E':
                    Console.WriteLine("Entered character is a vowel");
                    break;
                case 'i':
                case 'I':
                    Console.WriteLine("Entered character is a vowel");
                    break;
                case 'o':
                case 'O':
                    Console.WriteLine("Entered character is a vowel");
                    break;
                case 'u':
                case 'U':
                    Console.WriteLine("Entered character is a vowel");
                    break;
                default:
                    Console.WriteLine("Enterd character is a consonant");
                    break;
            }

        }
    }
}
