using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._6月
{
	public class Bounding
	{
		public void Do()
		{
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var jumpArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var count = 1;
			var total = 0;
			for(int i = 0;i < array[1]; i++)
			{
				total += jumpArray[i];
				if(total <= array[1])
				{
					count++;
				}
			}

			Console.WriteLine(count);
		}
	}
}
