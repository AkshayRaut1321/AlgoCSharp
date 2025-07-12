using System;

namespace AlgoCSharp.Algorithms
{
    /// <summary>
    /// Greedy, two pointers, sliding window
    /// </summary>
    public class BestTimeToBuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            int buyIndex = 0;
            int sellIndex = 1;
            int maxProfit = 0;

            while (sellIndex < prices.Length)
            {
                if (buyIndex < sellIndex)
                {
                    if (prices[buyIndex] < prices[sellIndex])
                    {
                        var currentProfit = prices[sellIndex] - prices[buyIndex];
                        maxProfit = Math.Max(maxProfit, currentProfit);
                        sellIndex++;
                    }
                    else
                    {
                        buyIndex++;
                    }
                }
                else
                {
                    sellIndex++;
                }
            }

            return maxProfit;
        }

        public int MaxProfitBruteForce(int[] prices)
        {
            int maxProfit = 0;
            int n = prices.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }

        public int MaxProfitOptimal(int[] prices)
        {
            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i]; // new lowest buy price
                }
                else
                {
                    int profit = prices[i] - minPrice;
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }

        public int MaxProfitDynamicProgramming(int[] prices)
        {
            int n = prices.Length;
            if (n == 0) return 0;

            int[] dp = new int[n];
            int minPrice = prices[0];

            for (int i = 1; i < n; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                dp[i] = Math.Max(dp[i - 1], prices[i] - minPrice);
            }

            return dp[n - 1];
        }
    }
}
