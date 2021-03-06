﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class WhenIhitmypocket
	{
		public void VestDo()
		{
			int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
			var K = input[0];
			var A = input[1];
			var B = input[2];

			long n = 0;
			if (B > A + 2 && K >= A + 1)
			{
				n = Math.Min(A, K + 1);
				int z = K - A + 1;
				n += (long)(z / 2) * (B - A);
				if (z % 2 == 1) n++;
			}
			else
			{
				n = K + 1;
			}
			Console.WriteLine(n);
		}

		public void NextDo()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			long K = input[0];
			long A = input[1];
			long B = input[2];

			long money = 0;
			long bisketNum = 1;
			if (A + 1 >= B)
				bisketNum += K;
			else
			{
				long changeTarget = K - A + 1;
				long changeNum = changeTarget / 2;
				long other = changeTarget % 2;

				bisketNum = changeNum * B + other;
			}

			Console.WriteLine(bisketNum);
		}

		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var K = input[0];
			var A = input[1];
			var B = input[2];

			var money = 0;
			var bisketNum = 1;
			if (A + 1 >= B)
				bisketNum += K ;
			else
			{
				for(int i = 0;i < K;i++)
				{
					if(money == 1)
					{
						money = 0;
						bisketNum += B;
					}
					else if(bisketNum >= A)
					{
						// 次でおしまいの時
						if(i+1 == K)
						{
							bisketNum += 1;
						}
						else
						{
							money = 1;
							bisketNum -= A;
						}
					}
					else
					{
						bisketNum += 1;
					}
				}
			}

			Console.WriteLine(bisketNum);
		}
	}
}
