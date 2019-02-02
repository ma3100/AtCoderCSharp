using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	public static void Main(string[] args)
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

		// Startは0
		answer[0] = 0;
		// 二番目のコスト。
		answer[1] = Math.Abs(input[1] - input[0]);

		for (int i = 2; i < N; i++)
		{
			var a = answer[i - 1] + Math.Abs(input[i] - input[i - 1]);
			var b = answer[i - 2] + Math.Abs(input[i] - input[i - 2]);

			if (a > b)
				answer[i] = b;
			else
				answer[i] = a;
		}
		Console.WriteLine(answer[N - 1]);

	}

}

