using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class ColorfulSubsequence
	{
		public static string Solve()
		{
			long MOD = 1000000007;
			long ans = 0;

			int N = int.Parse(Console.ReadLine());
			string S = Console.ReadLine();

			int[] cnt = new int[27];
			for (int i = 0; i < N; i++)
			{
				cnt[S[i] - 'a']++;
			}
			//Console.WriteLine(string.Join(", ",cnt));
			ans = 1;
			for (int i = 0; i < 27; i++)
			{
				ans = (ans * (cnt[i] + 1)) % MOD;
			}
			ans--;
			return ans.ToString();
		}

		public void Do()
		{
			// スペース区切りの整数の入力
			var N = int.Parse(Console.ReadLine());
			var S = Console.ReadLine();

			var answer = 0;
			for (int num = 1; num <= N; num++)
			{
				var combinations = Combination.Enumerate(S.ToArray(), num, withRepetition: false);
				var result = combinations.Select(x => new String(x)).ToList().Distinct();
				answer += result.Count();
			}
			Console.WriteLine(answer);
		}
	}

	public static class Combination
	{
		public static IEnumerable<T[]> Enumerate<T>(IEnumerable<T> items, int k, bool withRepetition)
		{
			if (k == 1)
			{
				foreach (var item in items)
					yield return new T[] { item };
				yield break;
			}
			foreach (var item in items)
			{
				var leftside = new T[] { item };

				// item よりも前のものを除く （順列と組み合わせの違い)
				// 重複を許さないので、unusedから item そのものも取り除く
				var unused = withRepetition ? items : items.SkipWhile(e => !e.Equals(item)).Skip(1).ToList();

				foreach (var rightside in Enumerate(unused, k - 1, withRepetition))
				{
					yield return leftside.Concat(rightside).ToArray();
				}
			}
		}
	}
}
