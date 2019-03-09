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
			var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			var result = input[0];
			for (long i = input[0] + 1; i <= input[1]; i++)
			{
				result = result ^ i;
			}
			Console.WriteLine(result);
		}
	}
}
