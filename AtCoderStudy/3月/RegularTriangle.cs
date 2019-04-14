using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	class RegularTriangle
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var result = input.All(x => x == input.First()) ? "Yes" : "No";
			Console.WriteLine(result);
		}
	}
}
