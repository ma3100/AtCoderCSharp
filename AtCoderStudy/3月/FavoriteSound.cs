using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class FavoriteSound
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var A = input[0];
			var B = input[1];
			var C = input[2];

			var result = B / A;
			if(result > C )
			{
				result = C;
			}

			Console.WriteLine(result);
		}
	}
}
