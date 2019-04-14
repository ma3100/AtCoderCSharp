using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class ColoringColorfully
	{
		public void Do()
		{
			var S = Console.ReadLine();
			var count = 0;
			var targetChar = S[0];

			for(int i = 1;i < S.Length;i++)
			{
				if(targetChar == S[i])
				{
					count++;
					if(S[i] == '0')
					{
						targetChar = '1';
					}
					else
					{
						targetChar = '0';
					}
				}
				else
				{
					targetChar = S[i];
				}
			}

			Console.WriteLine(count);
		}
	}
}
