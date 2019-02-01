using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	public static void Main(string[] args)
	{
		string s = Console.ReadLine();
		int l = s.Length;
		int[,] dp = new int[l + 1, l + 1];
		for (int i = 3; i <= l; i++)
		{
			for (int j = 0; j + i <= l; j++)
			{
				if (i > 3)
				{
					for (int k = j + 1; k < j + i; k++)
					{
						if (i % 3 == 0 && s[k] == 'w' && s[j] == 'i' && s[j + i - 1] == 'i' && dp[j + 1, k] == k - j - 1 && dp[k + 1, j + i - 1] == j + i - k - 2)
						{
							dp[j, j + i] = i;
							break;
						}
						dp[j, j + i] = Math.Max(dp[j, j + i], dp[j, k] + dp[k, j + i]);
					}
				}
				else if (s[j] == 'i' && s[j + 1] == 'w' && s[j + 2] == 'i') { dp[j, j + i] = 3; }
			}
		}
		Console.WriteLine(dp[0, l] / 3);
	}

}

