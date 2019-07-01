using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._6月
{
	public class BallDistribution
	{
		public void Do()
		{
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var N = array[0];
			var K = array[1];

			if(K <= 1)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(N - K);
			}
		}
	}
}
