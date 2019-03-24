using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class ATCoder
	{
		public void Do()
		{
			// 文字の入力
			var S = Console.ReadLine();
			var answerList = new List<char>() { 'A', 'C', 'G', 'T' };
			var count = 0;
			var maxCount = 0;
			foreach (var c in S)
			{
				if(answerList.Any(x => x == c))
				{
					count++;
				}
				else
				{
					if(maxCount < count)
					{
						maxCount = count;
					}
					count = 0;
				}
			}

			if (maxCount < count)
			{
				maxCount = count;
			}

			Console.WriteLine(maxCount);
		}
	}
}
