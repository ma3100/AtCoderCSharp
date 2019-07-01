using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

	static void Main(string[] args)
	{
		var array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
		var N = array[0];
		var K = array[1];
		var inputValues = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
		long count = 0;

		long totalValue = inputValues.Sum();
		var beforeTotalValue = totalValue;
		var endPoint = -1;
		for (int i = 0; i < N; i++)
		{
			var total = beforeTotalValue;

			// 値が小さかったら辞める
			if (total < K)
			{
				endPoint = i;
				break;
			}
			total -= inputValues[i];
			count++;
		}



		Console.WriteLine(count);
	}
}
