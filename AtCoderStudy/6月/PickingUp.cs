using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._6月
{
	public class PickingUp
	{
		public void Do()
		{
			var N = int.Parse(Console.ReadLine());
			var values = new Dictionary<Tuple<int, int>, int>();

			var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var beforeX = firstArray[0];
			var beforeY = firstArray[1];
			for (int i = 1; i < N; i++)
			{
				var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				var valueX = array[0] - beforeX;
				var valueY = array[1] - beforeY;

				var value = 0;
				var targetTuple = new Tuple<int, int>(valueX, valueY);
				var test = values.TryGetValue(targetTuple,out value);
				if(value == 0)
				{
					values.Add(targetTuple,1);
				}
				else
				{
					values[targetTuple] += 1;
				}

				beforeX = array[0];
				beforeY = array[1];
			}

			var max = values.OrderByDescending(x => x.Value).First().Value;
			Console.WriteLine(N - max);
		}
	}
}
