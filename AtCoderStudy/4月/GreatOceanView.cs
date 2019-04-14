using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class GreatOceanView
	{
		public void Do()
		{
			var N = int.Parse(Console.ReadLine());
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var max = array[0];
			var count = 0;
			for(int i = 0;i < N;i++)
			{
				if(max <= array[i])
				{
					count++;
					max = array[i];
				}
			}

			Console.WriteLine(count);
		}
	}
}
