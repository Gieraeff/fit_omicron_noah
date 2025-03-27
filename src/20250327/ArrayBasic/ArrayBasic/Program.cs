using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            int number;

            int[] numbers;
            numbers = new int[5];
                 

            //initiallisation
            number = -1;

            numbers[0] = 1;
            numbers[1] = 6;
            numbers[2] = 0;
            numbers[3] = 21;
            numbers[4] = 10;
            

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 2;
                Console.WriteLine("Value: " + numbers[i].ToString());
                
            }
        }
    }
}
