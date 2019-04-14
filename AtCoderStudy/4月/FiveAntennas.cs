using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class FiveAntennas
	{
		public void Do()
		{
			var array = new int[5];
			for (int i = 0; i < 5; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}

			var limit = int.Parse(Console.ReadLine());
			var flag = true;
			for (int i = 0; i < 4; i++)
			{
				for (int y = 4; y > i; y--)
				{
					if (array[y] - array[i] > limit)
					{
						flag = false;
					}
				}
			}

			if (flag)
			{
				Console.WriteLine("Yay!");
			}
			else
			{
				Console.WriteLine(":(");
			}
		}
	}
}
