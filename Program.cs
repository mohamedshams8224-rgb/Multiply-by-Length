using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Multiply_by_Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            List<int> input = new List<int>();
            bool check = true;

            while (check)
            {
                Console.WriteLine($"enter your {counter++} element");
                input.Add(Convert.ToInt16(Console.ReadLine()));
                Console.WriteLine("A-add a number \nP-print multiply");
                char response = Convert.ToChar(Console.ReadLine().ToLower());
                if (response == 'p')
                {
                    break;
                }
                else if (response == 'a')
                {
                    continue;
                }
                else
                {
                    check = false;
                    break;
                }
                
            }
            if (check == false)
            {
                Console.WriteLine("invalid input");
            }
            else
            {
                int[] output = multiArr(input);
                printOrder(output);
            }




        }
        static int[] multiArr(List<int> input)
        {
            int[] multiArr = new int[input.Count];
            for (int i=0; i < input.Count; i++)
            {
                multiArr[i] = input[i]* 2;
            }
                return multiArr;
            
        }
        static void printOrder(int[] arr)
        {
            Console.Write("your multiply Array : [ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write(" ]");
        }
    }
}