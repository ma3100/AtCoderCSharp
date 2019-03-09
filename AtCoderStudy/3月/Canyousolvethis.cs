using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class Canyousolvethis
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var N = input[0];
			var M = input[1];
			var C = input[2];

			input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var B = new int[M];

			// B代入
			for(int i = 0;i < M;i++)
			{
				B[i] = input[i];
			}

			var answer = 0;

			for (int i = 0; i < N; i++)
			{
				input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				var result = 0;
				// B代入
				for (int x = 0; x < M; x++)
				{
					result += input[x] * B[x];
				}
				if (result > C)
					answer++;
			}

			Console.WriteLine(answer);
		}
	}
}
