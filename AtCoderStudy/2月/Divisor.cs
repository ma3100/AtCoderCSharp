using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class Divisor
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var A = input[0];
			var B = input[1];

			if(B % A == 0)
			{
				Console.WriteLine(A + B);
			}
			else
			{
				Console.WriteLine(B - A);
			}
		}
	}
}
