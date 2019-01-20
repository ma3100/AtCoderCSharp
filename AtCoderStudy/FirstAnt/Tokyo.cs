using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class Tokyo
	{
		// 一度見つけたら
		public static int ans = 0;
		public static int n;
		public static string s = "";

		public void Do()
		{
			n = int.Parse(Console.ReadLine());
			string str;

			for (int i = 0; i < n; i++)
			{
				ans = 0;
				str = Console.ReadLine();
				for (int x = 0; x < str.Length - 4; x++)
				{
					s = str.Substring(x, 5);
					//Console.WriteLine(s+ " " +x);
					if (s == "tokyo" || s == "kyoto")
					{
						ans++;
						x += 4;
					}

				}
				Console.WriteLine(ans);
			}

		}


		public void ButDo()
		{
			var targetList = new List<string>() { "tokyo", "kyoto" };
			targetList = targetList.Select(x => string.Join("", x.Reverse())).ToList();


			// 入力回数
			var t = int.Parse(Console.ReadLine());
			for(int i = 0;i < t; i++)
			{
				// 文字列の入力
				var s = Console.ReadLine();
				s = string.Join("", s.Reverse());
				var count = 0;

				foreach(var target in targetList)
				{
					var index = s.IndexOf(target);
					while(index > -1)
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
}
