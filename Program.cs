using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array_Multiplication_in_C_.pptx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            
            int[] array = new int[length];

            Console.WriteLine("Enter a number: ");
            int num1 =Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                array[i] = num1 * (i + 1);
            }
            
            Console.WriteLine($"Multiplication Table for {num1}: ");
            for (int i = 0;i < length; i++)
            {
               Console.WriteLine($"{array[i]}"); 
            }
        }
    }
}
