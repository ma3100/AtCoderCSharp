using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class RightTriangle
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
			Console.WriteLine((input[0] * input[1]) / 2);

		}
	}
}
