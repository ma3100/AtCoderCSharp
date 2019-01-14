using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		// 文字列の入力
		var s = Console.ReadLine();
		var targetList = new List<string>() { "dream", "dreamer", "erase", "eraser" };

		// 逆さから読むとかぶらない・・・
		s = string.Join("", s.Reverse());
		targetList = targetList.Select(x => string.Join("", x.Reverse())).ToList();
		var hitFlag = true;

		for (int i = 0; i < s.Length;)
		{
			var flag2 = false;
			foreach (var word in targetList)
			{
				if (s.Length - i < word.Length)
					continue;
				else if (s.Substring(i, word.Length) == word)
				{
					i += word.Length;
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				hitFlag = false;
				break;
			}
		}

		if (hitFlag)
			Console.WriteLine("YES");
		else
			Console.WriteLine("NO");


	}

}