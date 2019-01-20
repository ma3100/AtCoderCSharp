using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		var targetList = new List<string>() { "tokyo", "kyoto" };
		targetList = targetList.Select(x => string.Join("", x.Reverse())).ToList();


		// 入力回数
		var t = int.Parse(Console.ReadLine());
		for (int i = 0; i < t; i++)
		{
			// 文字列の入力
			var s = Console.ReadLine();
			s = string.Join("", s.Reverse());
			var count = 0;

			foreach (var target in targetList)
			{
				var index = s.IndexOf(target);
				while (index > -1)
				{
					count++;
					s = s.Remove(index, 5);
					index = s.IndexOf(target);
				}
			}

			Console.WriteLine(count);
		}

	}

}
