using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class Handstand
	{
		public void Do()
		{
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var S = Console.ReadLine();
			var zeroStartList = new List<int>();
			var flag = true;

			for(int i = 0;i < S.Length;i++)
			{
				if(flag)
				{
					if (S[i] == '0')
					{
						zeroStartList.Add(i);
						flag = false;
					}
				}
				else
				{
					if (S[i] == '1')
					{
						flag = true;
					}
				}
			}

		}
	}
}
