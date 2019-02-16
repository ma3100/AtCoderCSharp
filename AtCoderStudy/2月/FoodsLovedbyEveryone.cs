using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class FoodsLovedbyEveryone
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var N = input[0];
			var M = input[1];

			var answer = new Dictionary<int, int>();

			for (int i = 0; i < N; i++)
			{
				// スペース区切りの整数の入力
				var inputFood = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				for (int x = 1; x <= inputFood[0]; x++)
				{
					if (answer.ContainsKey(inputFood[x]))
						answer[inputFood[x]]++;
					else
						answer.Add(inputFood[x], 1);
				}
			}

			var counter = 0;
			for (int i = 1; i <= M; i++)
			{
				if (answer.ContainsKey(i))
				{
					if (answer[i] == N)
						counter++;
				}
			}

			Console.WriteLine(counter);
		}
	}
}
