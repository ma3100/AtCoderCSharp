using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class OntheWay
	{
		public void Do()
		{
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int row = 0;
			int high = 0;
			if(array[0]>array[1])
			{
				row = array[1];
				high = array[0];
			}
			else
			{
				row = array[0];
				high = array[1];
			}

			if(row <= array[2] && array[2] <= high)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}

		}
	}
}
