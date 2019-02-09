using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class LCS
	{
		public void Do()
		{
			// DPテーブル
			var dp = new int[3000, 3000];

			var s = Console.ReadLine();
			var t = Console.ReadLine();

			// DPループ
			for (int x = 0; x < s.Length; ++x)
			{
				for (int y = 0; y < t.Length; ++y)
				{
					if (s[x] == t[y])
					{
						if (dp[x + 1, y + 1] < dp[x, y] + 1)
							dp[x + 1, y + 1] = dp[x, y] + 1;
					}
					if (dp[x + 1, y + 1] < dp[x + 1, y])
						dp[x + 1, y + 1] = dp[x + 1, y];

					if (dp[x + 1, y + 1] < dp[x, y + 1])
						dp[x + 1, y + 1] = dp[x, y + 1];
				}
			}

			// 復元
			string res = "";
			var i = s.Length;
			var j = t.Length;
			while (i > 0 && j > 0)
			{
				// (i-1, j) -> (i, j) と更新されていた場合
				if (dp[i,j] == dp[i - 1,j])
				{
					--i; // DP の遷移を遡る
				}

				// (i, j-1) -> (i, j) と更新されていた場合
				else if (dp[i,j] == dp[i,j - 1])
				{
					--j; // DP の遷移を遡る
				}

				// (i-1, j-1) -> (i, j) と更新されていた場合
				else
				{
					res = s[i - 1] + res; // このとき s[i-1] == t[j-1] なので、t[j-1] + res でも OK
					--i;
					--j; // DP の遷移を遡る
				}
			}
			Console.WriteLine(res);
		}

	}
}
