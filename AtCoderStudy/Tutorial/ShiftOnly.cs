using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class ShiftOnly
	{
		static int minNum = 1;
		static int maxNum = 200;


		public void Do()
		{
			// 整数の入力
			int a = int.Parse(Console.ReadLine());

			if (!chectNum(a))
			{
				Console.WriteLine("入力値が不正です。");
			}

			try
			{
				// スペース区切りの整数の入力
				var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				if (input.Any(x => x > 1000000000))
				{
					Console.WriteLine("入力値が不正です");
				}
				else
				{
					var answer = checkCount(input, 0);
					Console.WriteLine(answer);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("入力値が不正です");
			}
		}

		private static int checkCount(int[] targetList, int count)
		{
			// 全て偶数の場合同じ処理を繰り返す
			if (targetList.All(x => x % 2 == 0))
			{
				targetList = targetList.Select(i => i / 2).ToArray();
				count = checkCount(targetList, ++count);
			}
			return count;
		}

		// 入力チェック1
		private static bool chectNum(int target)
		{
			return minNum <= target && target <= maxNum;
		}

	}
}
