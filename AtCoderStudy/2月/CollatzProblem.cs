﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class CollatzProblem
	{
		public void Do()
		{
			var s = int.Parse(Console.ReadLine());
			var flag = true;
			var count = 3;
			var value = s;
			var valueArray = new int[1000000];

			while(flag)
			{
				// 偶数の時
				if(value % 2 == 0)
				{
					value = value / 2;
				}
				// 奇数の時
				else
				{
					value = value * 3 + 1;
				}

				if (valueArray[value] != 0)
					flag = false;
				else
				{
					valueArray[value] = 1;
					count++;
				}				
			}

			Console.WriteLine(count);
		}
	}
}
