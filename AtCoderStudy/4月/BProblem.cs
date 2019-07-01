using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class BProblem
	{
		public void Do()
		{
			var N = int.Parse(Console.ReadLine());
			var S = Console.ReadLine();
			var K = int.Parse(Console.ReadLine());

			var target = S[K - 1];
			var result = new char[N];

			for (int i = 0; i < N; i++)
			{
				if (S[i] == target)
					result[i] = target;
				else
					result[i] = '*';
			}

			Console.WriteLine(new String(result));
		}
	}
}
