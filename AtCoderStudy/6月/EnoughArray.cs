using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._6月
{
	public class EnoughArray
	{
		public void Do()
		{
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var N = array[0];
			var K = array[1];
			var inputValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var count = 0;

			var total = 0;
			for(int i = 0;i < N; i++)
			{
				total = 0;
				for(int t = i;t < N; t++)
				{
					total += inputValues[t];
					if(total >= K)
					{
						count = count + K - t - 1;
						break;
					}
				}
			}

			Console.WriteLine(count);
		}
	}
}
