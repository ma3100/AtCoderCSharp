using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	public static void Main(String[] args)
	{
		var N = int.Parse(Console.ReadLine());
		// スペース区切りの整数の入力
		var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();

		var min = input[0];
		for (int i = 1; i < N; i++)
		{
			var value = input[i] % input[0];
			if (value != 0)
			{
				if (min > value)
					min = value;
			}
		}

		var flag = true;
		var targetValue = input[0];
		while (flag)
		{
			var value = targetValue % min;
			if (value == 0)
			{
				flag = false;
			}
			else
			{
				targetValue = min;
				min = value;
			}
		}

		Console.WriteLine(min);
	}
}

