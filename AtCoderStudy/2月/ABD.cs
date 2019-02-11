using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class ABD
	{
		public void Do()
		{
			var N = int.Parse(Console.ReadLine());
			if (N >= 1000)
				Console.WriteLine("ABD");
			else
				Console.WriteLine("ABC");
		}
	}
}
