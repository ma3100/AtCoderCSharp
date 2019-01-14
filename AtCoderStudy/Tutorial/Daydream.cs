using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class Daydream
	{
		public void Do()
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

		public void ButDo()
		{
			// 文字列の入力
			var s = Console.ReadLine();
			var replaceStringList = new List<string>() { s };
			var targetList = new List<string>() { "dream", "dreamer", "erase", "eraser" };
			var nextFlag = true;
			var hitFlag = false;

			while (nextFlag)
			{
				var nextReplaceList = new List<string>();
				replaceStringList.ForEach(x => {
					var hitStringList = targetList.Where(y => x.StartsWith(y)).ToList();

					if (hitStringList.Any())
					{
						hitStringList.ForEach(z => {
							var replaceString = x.Substring(z.Length);
							if (replaceString.Length == 0)
							{
								hitFlag = true;
							}
							else
							{
								nextReplaceList.Add(x.Substring(z.Length));
							}
						});
					}
				});

				nextFlag = nextReplaceList.Any();
				replaceStringList = nextReplaceList;
			}

			if (hitFlag)
				Console.WriteLine("Yes");
			else
				Console.WriteLine("No");
		}
	}
}
