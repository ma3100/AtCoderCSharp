using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class Iwi
	{
		public void BestDo()
		{
			string s = Console.ReadLine();
			int l = s.Length;
			int[,] dp = new int[l + 1, l + 1];
			for (int i = 3; i <= l; i++)
			{
				for (int j = 0; j + i <= l; j++)
				{
					if (i > 3)
					{
						for (int k = j + 1; k < j + i; k++)
						{
							if (i % 3 == 0 && s[k] == 'w' && s[j] == 'i' && s[j + i - 1] == 'i' && dp[j + 1, k] == k - j - 1 && dp[k + 1, j + i - 1] == j + i - k - 2)
							{
								dp[j, j + i] = i;
								break;
							}
							dp[j, j + i] = Math.Max(dp[j, j + i], dp[j, k] + dp[k, j + i]);
						}
					}
					else if (s[j] == 'i' && s[j + 1] == 'w' && s[j + 2] == 'i') { dp[j, j + i] = 3; }
				}
			}
			Console.WriteLine(dp[0, l] / 3);
		}

		public void Do()
		{
			// 文字列の入力
			var input = Console.ReadLine();
			var resultList = new List<int>();
			for (int i = 0; i < input.Length; i++)
			{
				// 文字が三文字以上残っているなら
				if (i + 3 <= input.Length)
				{
					var targetValue = input.Substring(i, 3);
					if (targetValue == "iwi")
					{
						var before = input.Substring(0, i);
						var after = input.Substring(i + 3);

						resultList.Add(resolve(before + after, 1));
					}
				}
			}

			Console.WriteLine(resultList.Max());
		}

		public int resolve(string value,int count)
		{
			for (int i = 0; i < value.Length; i++)
			{
				// 文字が三文字以上残っているなら
				if (i + 3 <= value.Length)
				{
					var targetValue = value.Substring(i, 3);
					if (targetValue == "iwi")
					{
						var before = value.Substring(0, i);
						var after = value.Substring(i + 3);

						resolve(before + after, ++count);
					}
				}
			}

			return count;
		}
	}
}
