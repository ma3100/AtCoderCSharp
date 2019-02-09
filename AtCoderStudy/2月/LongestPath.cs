using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AtCoderStudy._2月
{
	public class LongestPath
	{
		static int[] h;
		static List<int>[] li;

		public void Do()
		{
			// スペース区切りの整数の入力
			var inputCondition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var n = inputCondition[0];
			var m = inputCondition[1];

			h = new int[n + 1];
			li = new List<int>[n + 1];
			for (int i = 1; i <= n; i++)
			{
				li[i] = new List<int>();
				h[i] = -1;
			}
			for (int i = 0; i < m; i++)
			{
				int[] q = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				li[q[0]].Add(q[1]);
			}
			int ans = 0;
			for (int i = 1; i <= n; i++)
			{
				ans = Math.Max(fu(i), ans);
			}
			Console.WriteLine(ans);
		}
		static int fu(int a)
		{
			if (h[a] != -1) { return h[a]; }
			int p = 0;
			for (int i = 0; i < li[a].Count; i++)
			{
				if (h[li[a][i]] == -1)
				{
					h[li[a][i]] = fu(li[a][i]);
				}
				p = Math.Max(h[li[a][i]] + 1, p);
			}
			return p;
		}
	}
}
