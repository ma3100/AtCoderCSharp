using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class WhiteCells
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var H = input[0];
			var W = input[1];
			
			// スペース区切りの整数の入力
			input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var h = input[0];
			var w = input[1];

			Console.WriteLine((H - h) * (W - w));
		}
	}
}
