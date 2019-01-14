using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class WelcomeToAtCoder
	{
		static int minNum = 1;
		static int maxNum = 1000;
		static int minLength = 1;
		static int maxLength = 100;

		public void Do()
		{
			// 整数の入力
			int a = int.Parse(Console.ReadLine());
			// スペース区切りの整数の入力
			string[] input = Console.ReadLine().Split(' ');
			int b = int.Parse(input[0]);
			int c = int.Parse(input[1]);
			if (!chectNum(a) && !chectNum(b) && !chectNum(c))
			{
				Console.WriteLine("入力値が不正です。");
			}

			// 文字列の入力
			string s = Console.ReadLine();
			//出力
			Console.WriteLine((a + b + c) + " " + s);
		}

		private static bool chectNum(int target) {
			return minNum <= target && target <= maxNum;
		}

		private static bool chectString(string target)
		{
			return minLength <= target.Length && target.Length <= maxLength;
		}

	}
}
