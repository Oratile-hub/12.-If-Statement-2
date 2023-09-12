using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.If_Statement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The max is ");
            Console.WriteLine(GetMax(number1 ,number2));



            //freeze console
            Console.Read();
        }
        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }   
            else
            {  
                return num2;
            }
        
            
        
        }
    }
}
