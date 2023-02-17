using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestLogic
{
    internal class Logic
    {
        public static void nomor1()
        {
            Console.Write("Input n =  ");
            int input = Convert.ToInt32(Console.ReadLine());

            char[,] matrix = new char[input, input + 3];
            int[,] matrix2 = new int[input, input + 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j >= i+1 && j <= i+2)
                    {
                        matrix[i, j] = '*';
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        matrix2[i, j] = j+1;
                        Console.Write(matrix2[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

        }


        public static void Nomor2()
        {
            var hargaa = new int[] { 300, 350, 500 };
            decimal harga = 0;
            var times = new int[] { 0, 10, 60 };
            var stock_prices_yesterday = new List<int> { 10, 7, 5, 8, 11, 9, 1 };
        
            int someValue = stock_prices_yesterday[4];
            stock_prices_yesterday = stock_prices_yesterday.Select(x => someValue- x).ToList();
            int maxIndex = -1;
            int maxInt = Int32.MinValue;
            for (int i = 0; i < stock_prices_yesterday.Count(); i++)
            {
                if (!(times[0] < 1))
                {
                    harga = 300;
                    
                }
                else if (times[1] >= 1 || times[1] <= 10)
                {
                    harga = 350;
                   
                }
                else if (times[2] <= 60)
                {
                    harga = 500;
     
                }
            }
            get_max_profit(stock_prices_yesterday.Count);

            decimal get_max_profit(decimal harga1)
            {
                for (int i = 0; i < stock_prices_yesterday.Count; i++)
                {
                    int value = stock_prices_yesterday[i];
                    if (!(stock_prices_yesterday[i] == stock_prices_yesterday[6]))
                    {
                        if (value > maxInt)
                        {
                            maxInt = value;
                            maxIndex = i;
                        }
                    }
                }
                Console.WriteLine($"Maximum profit is {maxInt}");
                return harga;
            }

        }

        public static void nomor3()
        {
            int[] bob = { 3, 4, 6, 10, 11, 15 };
            int[] alice = { 1, 5, 8, 12, 14, 19 };
            int[] mergedArray = new int[bob.Length + alice.Length];

            for (int i = 0; i < bob.Length; i++)
            {
                mergedArray[i] = bob[i];
            }

            for (int j = 0; j < alice.Length; j++)
            {
                mergedArray[alice.Length + j] = alice[j];
            }

            for (int i = 0; i < mergedArray.Length - 1; i++)
            {
                for (int j = 0; j < mergedArray.Length - i - 1; j++)
                {
                    if (mergedArray[j] > mergedArray[j + 1])
                    {
                        int temp = mergedArray[j];
                        mergedArray[j] = mergedArray[j + 1];
                        mergedArray[j + 1] = temp;
                    }
                }
            }

            foreach (int value in mergedArray)
            {
                Console.Write($" {value} ");
            }
        }

        public static void nomor4()
        {
            int[] arr = { 1, 7, 3, 4 };

            for (int i = 0; i < arr.Length; i++)
            {
                int excludeIndex = i;
                int product = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j != excludeIndex)
                    {
                        product *= arr[j];
                    }
                }
                Console.Write(product + " ");
            }
        }

        public static void nomor5()
        {
            int[] arr = { 1, 7, 3, 4 };

            Console.WriteLine("Array = [1, 7, 3, 4]");
            Console.Write("Input n =  ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] result = new int[7];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int product = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        product += arr[i] + arr[j];
                        result[index] = product;
                        index++;
                    }
                    product = 0;
                }
            }

            bool found = false;
            for (int i = 0; i < result.Length; i++)
            {
                if (input == result[i])
                {
                    found = true;
                    Console.WriteLine($"Output : {found} ");
                    break;
                }
                else
                {
                    found = false;
                    Console.WriteLine($"Output : {found} ");
                    break;
                }
            }
        }
    }
}
