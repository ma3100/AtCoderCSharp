using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class Frog2
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var inputCondition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var N = inputCondition[0];
			var K = inputCondition[1];
			var answer = new int[N];

			// 配列を初期化
			for (int i = 0; i < N; i++)
			{
				answer[i] = 100000;
			}

			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			// Startは0
			answer[0] = 0;
			for (int i = 1; i < K; i++)
			{
				if (i >= N)
					break;
				// 一回のジャンプで飛べるコスト。
				answer[i] = Math.Abs(input[i] - input[0]);
			}


			for (int i = K; i < N; i++)
			{
				for (int x = 1; x <= K; x++)
				{
					var value = answer[i - x] + Math.Abs(input[i] - input[i - x]);
					if (answer[i] > value)
						answer[i] = value;
				}
			}
			Console.WriteLine(answer[N - 1]);
		}
	}
}
