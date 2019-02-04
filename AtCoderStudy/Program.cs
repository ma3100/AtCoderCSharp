using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	public static void Main(string[] args)
	{
		// 何日分の予定があるか
		var N = int.Parse(Console.ReadLine());
		var answer = 0;
		var beforeIndex = -1;

		for (int i = 0; i < N; i++)
		{
			// スペース区切りの整数の入力
			var inputVacation = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var max = 0;
			var index = 0;
			for (int x = 0; x < inputVacation.Length; x++)
			{
				if (beforeIndex != x)
				{
					if (max < inputVacation[x])
					{
						max = inputVacation[x];
						index = x;
					}
				}
			}

			answer += max;
			beforeIndex = index;
		}

		Console.WriteLine(answer);
	}

}

