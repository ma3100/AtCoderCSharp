using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class RedorBlue
	{
		public void Do()
		{
			// 文字の入力
			var N = int.Parse( Console.ReadLine());
			var s = Console.ReadLine();

			var redCount = s.Count(x => x == 'R');
			var blueCount = s.Count(x => x == 'B');

			var result = redCount > blueCount ? "Yes" : "No";
			Console.WriteLine(result);
		}

	}
}
