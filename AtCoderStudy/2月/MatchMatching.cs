using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BI = System.Numerics.BigInteger;

namespace AtCoderStudy._2月
{
	public class MatchMatching
	{
		int N, M;
		int[] A;

		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			N = input[0];
			M = input[1];
			A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int[] C = new int[] { 0, 2, 5, 5, 4, 5, 6, 3, 7, 6 };
			BI[] dp = new BI[N + 1];
			for (int i = 0; i < N; i++)
			{
				if (i != 0 && dp[i] == 0) continue;
				for (int j = 0; j < A.Length; j++)
				{
					if (C[A[j]] + i > N) continue;
					var nv = dp[i] * 10 + A[j];
					if (nv > dp[i + C[A[j]]])
					{
						dp[i + C[A[j]]] = nv;
					}
				}
			}

			Console.WriteLine(dp[N]);
		}
	}
}
