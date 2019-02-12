using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class StoneMonument
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var flag = true;
			var count = 2;
			var answer = 0;
			var targetIndex = 0;
			while (flag)
			{
				var treeSize = GetTreeSize(count);
				if (treeSize > input[targetIndex])
				{
					answer = treeSize - input[targetIndex];
					targetIndex++;
					// 次にいけない時。
					if (targetIndex == 2)
						flag = false;
				}
				else
				{
					targetIndex = 0;
					answer = 0;
				}
				count++;
			}

			Console.WriteLine(answer);
		}

		private int GetTreeSize(int value)
		{
			if (value == 1)
				return value;

			return (GetTreeSize(value - 1));
		}
	}
}
