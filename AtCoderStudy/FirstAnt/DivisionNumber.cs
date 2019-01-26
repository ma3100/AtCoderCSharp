using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class DivisionNumber
	{
		const int A = 1000000007;
		public void Do()
		{
			var input = Console.ReadLine().Split(' ');
			var N = int.Parse(input[0]);
			var S = int.Parse(input[1]);
			var K = int.Parse(input[2]);

			int m = S - (N - 1) * N * K / 2;
			int c = 0;
			if (m == 0) { c = 1; }
			else
			{
				for (var l = 1; l <= N && l <= m; l++)
				{
					long[] t = new long[m - l + 2];
					for (var i = 0; i < t.Length; i++) { t[i] = 1; }
					for (var i = 2; i <= l; i++)
					{
						for (var j = i; j <= m - l; j++)
						{
							t[j] = (t[j] + t[j - i]) % A;
						}
					}
					c = (int)((c + t[m - l]) % A);
				}
			}
			Console.WriteLine(c);
		}
	}
}
