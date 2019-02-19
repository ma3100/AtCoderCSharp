using System;
using System.Collections.Generic;
using System.Linq;
using BI = System.Numerics.BigInteger;

class Program
{
	public static void Main(String[] args)
	{
		// スペース区切りの整数の入力
		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

		var N = input[0];
		var K = input[1];

		if (N >= (2 * K - 1))
			Console.WriteLine("YES");
		else
			Console.WriteLine("NO");
	}
}

