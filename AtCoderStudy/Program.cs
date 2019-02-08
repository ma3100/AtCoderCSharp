using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	public static void Main(string[] args)
	{
		var N = int.Parse(Console.ReadLine());
		// 結果を格納する配列
		int[] answer = new int[N + 1];

		// 引き出せるお金の種類リスト
		List<int> x = new List<int>();

		// 1
		int z = 1;
		x.Add(z);

		// 6の乗数
		while (true)
		{
			z *= 6;
			if (z > N) break;
			x.Add(z);
		}

		// 9の乗数
		z = 1;
		while (true)
		{
			z *= 9;
			if (z > N) break;
			x.Add(z);
		}


		int counter = 1;
		List<int> current = new List<int>();
		current.Add(0);

		// 探したい数字に回数が入力されるまで回す
		while (answer[N] == 0)
		{
			List<int> next = new List<int>();
			foreach (int n in current)
			{
				foreach (int m in x)
				{
					if (n + m > N) continue;
					if (answer[n + m] == 0)
					{
						answer[n + m] = counter;
						next.Add(n + m);
					}
				}
			}
			counter++;
			current = next;
		}
		Console.WriteLine(answer[N]);
	}

}

