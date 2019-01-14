using System;

namespace AtCoderStudy.Tutorial
{
	public class ABC_A
	{
		static int minNum = 1;
		static int maxNum = 10000;

		public void Do()
		{
			// スペース区切りの整数の入力
			string[] input = Console.ReadLine().Split(' ');
			int a = int.Parse(input[0]);
			int b = int.Parse(input[1]);
			if (!chectNum(a) && !chectNum(b) )
			{
				Console.WriteLine("入力値が不正です。");
			}

			if (a % 2 == 0 && b % 2 == 0)
				Console.WriteLine("Even");
			else
				Console.WriteLine("Odd");
		}

		private static bool chectNum(int target)
		{
			return minNum <= target && target <= maxNum;
		}

	}


}
