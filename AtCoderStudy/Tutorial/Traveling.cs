using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class Traveling
	{
		public void Do()
		{
			// 整数の入力
			int n = int.Parse(Console.ReadLine());
			var flag = true;

			for (int i = 1; i <= n; i++)
			{
				// スペース区切りの整数の入力
				var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				var time = inputArray[0];
				var x = inputArray[1];
				var y = inputArray[2];

				if (x + y > time)
				{
					flag = false;
					break;
				}

				if (time % 2 != (x + y) % 2)
				{
					flag = false;
					break;
				}
			}

			if (flag)
				Console.WriteLine("Yes");
			else
				Console.WriteLine("No");
		}
	}
}
