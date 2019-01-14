using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class Coins
	{
		public void Do()
		{
			// 整数の入力
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int x = int.Parse(Console.ReadLine());
			int totalCount = 0;
			for (int i = 0; i <= a; i++)
			{
				for (int j = 0; j <= b; j++)
				{
					for (int k = 0; k <= c; k++)
					{
						if (500 * i + 100 * j + 50 * k == x)
							totalCount++;
					}
				}
			}

			Console.WriteLine(totalCount);

		}

	}
}
