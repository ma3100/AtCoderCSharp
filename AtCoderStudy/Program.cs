using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	public static void Main(string[] args)
	{
		// 文字列の入力
		var input = Console.ReadLine();
		var resultList = new List<int>();
		for (int i = 0; i < input.Length; i++)
		{
			// 文字が三文字以上残っているなら
			if (i + 3 <= input.Length)
			{
				var targetValue = input.Substring(i, 3);
				if (targetValue == "iwi")
				{
					var before = input.Substring(0, i);
					var after = input.Substring(i + 3);

					resultList.Add(resolve(before + after, 1));
				}
			}
		}

		Console.WriteLine(resultList.Max());
	}

	public static int resolve(string value, int count)
	{
		for (int i = 0; i < value.Length; i++)
		{
			// 文字が三文字以上残っているなら
			if (i + 3 <= value.Length)
			{
				var targetValue = value.Substring(i, 3);
				if (targetValue == "iwi")
				{
					var before = value.Substring(0, i);
					var after = value.Substring(i+3);

					resolve(before + after, ++count);
				}
			}
		}

		return count;
	}
}

