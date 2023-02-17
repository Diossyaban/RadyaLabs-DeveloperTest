using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogic
{
    internal class dios
    {

        public static void Nomor2()
        {
            var hargaa = new int[] { 300, 350, 500 };
            decimal harga = 0;
            var times = new int[] { 0, 10, 60 };
            var stock_prices_yesterday = new List<int> { 10, 7, 5, 8, 11, 9, 1 };

            int someValue = stock_prices_yesterday[4];
            stock_prices_yesterday = stock_prices_yesterday.Select(x => someValue - x).ToList();
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
    }
}
