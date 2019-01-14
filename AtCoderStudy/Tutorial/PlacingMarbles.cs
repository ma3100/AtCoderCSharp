using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class PlacingMarbles
	{
		public void Do()
		{
			// 入力
			string a = Console.ReadLine();
			var count = a.Count(x => x == '1');
			Console.WriteLine(count);
		}
	}
}
