namespace Problems.LeetCode
{
    public class BestTimeToBuyAndSellStock
    {
        public static int Solve(int[] prices)
        {
            int ans = 0;
            int min = int.MaxValue;
            foreach (var price in prices)
            {
                if (price < min)
                {
                    min = price;
                }

                if (price > min)
                {
                    ans = price - min > ans ?  price -min : ans;
                }
            }

            return ans;
        }
    }
}