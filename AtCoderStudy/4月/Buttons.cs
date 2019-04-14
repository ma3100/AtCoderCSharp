using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class Buttons
	{
		public void Do()
		{
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var answer = 0;
			for(int i = 0;i < 2;i++)
			{
				if(array[0] > array[1])
				{
					answer += array[0];
					array[0]--;
				}
				else
				{
					answer += array[1];
					array[1]--;
				}
			}
			Console.WriteLine(answer);
		}
	}
}
