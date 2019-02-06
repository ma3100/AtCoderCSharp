using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class Knapsack2
	{
		public void Do()
		{
			long[] weight = new long[100];
			long[] value = new long[100];

			// DPテーブル
			long[,] dp = new long[100, 10000];

			// スペース区切りの整数の入力
			var inputCondition = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			var N = inputCondition[0];
			var W = inputCondition[1];

			// dpを全て大きな値で初期化
			for (int i = 0; i < 100; ++i)
			{
				for (int j = 0; j < 10000; ++j)
				{
					dp[i,j] = 1000000000;
				}
			}

			for (int i = 0; i < N; i++)
			{
				// スペース区切りの整数の入力
				var inputWeightAndValue = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
				weight[i] = inputWeightAndValue[0];
				value[i] = inputWeightAndValue[1];
			}

			// DPループ
			for (int i = 0; i < N; ++i)
			{
				for (int sum_w = 0; sum_w <= W; ++sum_w)
				{
					// i 番目の品物を選ぶ場合
					if (sum_w - weight[i] >= 0)
					{
						if (dp[i + 1, sum_w] > (dp[i, sum_w - weight[i]] + value[i]))
						{
							dp[i + 1, sum_w] = dp[i, sum_w - weight[i]] + value[i];
						}
					}

					// i 番目の品物を選ばない場合
					if (dp[i + 1, sum_w] > (dp[i, sum_w]))
					{
						dp[i + 1, sum_w] = (dp[i, sum_w]);
					}
				}
			}

			Console.WriteLine(dp[N, W]);
		}

	}
}
