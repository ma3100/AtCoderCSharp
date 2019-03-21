using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public static class Reversi
	{
		const int MOD = 1000000007;

		public static void Solve()
		{
			int N;
			long res = 1;
			int[] tmp = new int[200010]; // 各色の一時的なDP値の格納場所
			N = int.Parse(Console.ReadLine());
			int[] array = new int[N + 1];
			for (int i = 1; i <= N; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			int[] dp = new int[N + 1];
			dp[0] = dp[1] = 1; // 最初の石までのDP値は1
			tmp[array[1]] = 1;

			for (int i = 2; i <= N; i++)
			{
				if (array[i] == array[i - 1])
				{
					dp[i] = dp[i - 1];
				}
				else
				{
					tmp[array[i]] += dp[i - 1];
					tmp[array[i]] %= MOD;
					dp[i] = tmp[array[i]];
				}
			}
			res = dp[N];

			Console.WriteLine(res);

		}
	}
}
