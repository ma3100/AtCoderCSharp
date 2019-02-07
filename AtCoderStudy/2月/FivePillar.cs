using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class FivePillar
	{
		public void Do()
		{
			var N = int.Parse(Console.ReadLine());
			var answer = new int[N];

			// 配列を初期化
			for (int i = 0; i < N; i++)
			{
				answer[i] = 100000;
			}

			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			// 初期値の設定
			answer[0] = 0;
			answer[1] = Math.Abs(input[1] - input[0]);

			for (int i = 2; i < N; i++)
			{
				var beforeOne = answer[i - 1] + Math.Abs(input[i] - input[i - 1]);
				var beforeTwo = answer[i - 2] + Math.Abs(input[i] - input[i - 2]);

				// 小さい方を詰める
				answer[i] = beforeOne < beforeTwo
					? beforeOne
					: beforeTwo;
			}

			// 回答出力
			Console.WriteLine(answer[N - 1]);
		}
	}
}
