using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class CardGameforTwo
	{
		public void Do()
		{
			// 整数の入力
			int n = int.Parse(Console.ReadLine());
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => -x).ToArray();

			var aSum = 0;
			var bSum = 0;

			for(int i = 0; i < n; i++)
			{
				if (i % 2 == 0)
					aSum += input[i];
				else
					bSum += input[i];
			}

			Console.WriteLine(aSum - bSum);
		}
	}
}
