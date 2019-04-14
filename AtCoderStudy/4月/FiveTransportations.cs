using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class FiveTransportations
	{
		public void Do()
		{
			var N = int.Parse(Console.ReadLine());

			// 移動がセットされる
			var array = new int[5];
			for (int i = 0; i < 5; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}

			var flag = true;
			var hitoMap = new int[6];
			hitoMap[0] = N;
			while(flag)
			{
				flag = false;
				for(int i = 0;i < 6;i++)
				{
					if(hitoMap[i] > 0)
					{
						flag = true;
						var moveNum = 0;
						if (hitoMap[i] > array[i])
						{
							moveNum = array[i];
						}
						else
						{
							moveNum = array[i] - hitoMap[i];
						}

						hitoMap[i] -= moveNum;
						hitoMap[i + 1] += moveNum;
					}
				}
			}
		}
	}
}
