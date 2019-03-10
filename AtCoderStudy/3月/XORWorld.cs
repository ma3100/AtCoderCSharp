using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class XORWorld
	{
		public void Do()
		{
			var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
			long A = input[0], B = input[1];
			Console.WriteLine(F(A - 1) ^ F(B));
		}
		static long F(long x) {
			return new[] { x, 1, x + 1, 0 }[(x + 4) % 4];
		}
	}
}
