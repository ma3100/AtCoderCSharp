using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class Stones
	{
		public void Do()
		{
			var N = int.Parse(Console.ReadLine());
			var S = Console.ReadLine();

			var white = S.Count(x => x == '.');
			var black = S.Count(x => x == '#');

			if(black > white)
			{
				Console.Write(white);
			}
			else
				Console.Write(black);
		}
	}
}
