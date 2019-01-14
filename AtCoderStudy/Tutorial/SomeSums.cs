using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class SomeSums
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var targetList = new List<int>();
			// 最初に指定された値までループ
			for (int i = 1; i <= input[0]; i++)
			{
				var sum = 0;
				var checkTargetValue = i;
				while (checkTargetValue > 0)
				{
					sum += checkTargetValue % 10;
					checkTargetValue = checkTargetValue / 10;
				}

				if (sum >= input[1] && input[2] >= sum)
				{
					targetList.Add(i);
				}
			}
			var answer = targetList.Sum();
			Console.WriteLine(answer);
		}
	}
}
