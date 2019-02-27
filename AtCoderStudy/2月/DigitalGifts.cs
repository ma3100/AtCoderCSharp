using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class DigitalGifts
	{
		public void Do()
		{
			var N = int.Parse(Console.ReadLine());
			double total = 0;

			for (int i = 0; i < N; i++)
			{
				// スペース区切りの整数の入力
				var input = Console.ReadLine().Split(' ');
				if (input[1] == "JPY")
				{
					total += double.Parse(input[0]);
				}
				else
				{
					total += double.Parse(input[0]) * 380000;
				}
			}
			Console.WriteLine(total);
		}
	}
}
