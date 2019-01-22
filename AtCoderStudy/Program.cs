using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		// スペース区切りの整数の入力
		var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
		var X = input[0];
		var Y = input[1];
		var count = 0;

		while (Y >= X)
		{
			count++;
			X = X * 2;
		}

		Console.WriteLine(count);

	}

}


