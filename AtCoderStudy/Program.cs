using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	public static void Main(String[] args)
	{
		// スペース区切りの整数の入力
		var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
		Console.WriteLine((input[0] * input[1]) / 2);
	}
}

