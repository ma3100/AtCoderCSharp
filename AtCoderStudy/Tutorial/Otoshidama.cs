using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class Otoshidama
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var moneyNum = input[0];
			var totalMoney = input[1];
			var answerArray = new int[3] { -1, -1, -1 };
			var answerFlag = false;

			for (int x = 0; x <= moneyNum; x++)
			{
				if (answerFlag)
					break;

				for (int y = 0; y <= moneyNum - x; y++)
				{
					var answer = 10000 * x + 5000 * y + 1000 * (moneyNum - x - y);
					if (totalMoney == answer)
					{
						answerArray[0] = x;
						answerArray[1] = y;
						answerArray[2] = moneyNum - x - y;
						answerFlag = true;
						break;
					}
				}
			}

			Console.WriteLine(answerArray[0] + " " + answerArray[1] + " " + answerArray[2] + " ");
		}
	}
}
