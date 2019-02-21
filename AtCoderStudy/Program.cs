using System;
using System.Collections.Generic;
using System.Linq;
using BI = System.Numerics.BigInteger;

class Program
{
	public static void Main(String[] args)
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
}

