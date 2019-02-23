using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class Ears
	{
		public void Do()
		{
			var L = Int32.Parse(Console.ReadLine());
			var A = new List<long>();
			for (int i = 0; i < L; ++i)
			{
				A.Add(Int64.Parse(Console.ReadLine()));
			}
			var dp = new long[L, 5];
			for (int i = 0; i < L; ++i)
			{
				var num = A[i] % 2;
				var even = A[i] == 0 ? 2 : num == 0 ? 0 : 1;
				var odd = A[i] == 0 ? 1 : num == 0 ? 1 : 0;
				var value = GetValue(dp, i, 0);
				dp[i, 0] = A[i] + value;
				value = GetValue(dp, i, 1, value);
				dp[i, 1] = even + value;
				value = GetValue(dp, i, 2, value);
				dp[i, 2] = odd + value;
				value = GetValue(dp, i, 3, value);
				dp[i, 3] = even + value;
				value = GetValue(dp, i, 4, value);
				dp[i, 4] = A[i] + value;
			}
			var ans = Math.Min(dp[L - 1, 0],
					  Math.Min(dp[L - 1, 1],
					  Math.Min(dp[L - 1, 2],
					  Math.Min(dp[L - 1, 3], dp[L - 1, 4]))));
			Console.WriteLine(ans);
		}
		static long GetValue(long[,] dp, long num, int section, long value = long.MaxValue)
		{
			if (num == 0) return 0;
			else
			{
				switch (section)
				{
					case 0: return dp[num - 1, section];
					default: return Math.Min(value, dp[num - 1, section]);
				}
			}
		}
	}
}
