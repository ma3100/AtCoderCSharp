using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

	static void Main()
	{
		int N = int.Parse(Console.ReadLine());
		var cardList = new int[N];
		for (int i = 0; i < N; i++)
		{
			cardList[i] = int.Parse(Console.ReadLine());
		}

		var count = 0;
		var targetValue = cardList[0];
		for (int i = 1; i < N; i++)
		{
			if (cardList[i] < targetValue)
			{
				count++;
			}
			else
			{
				targetValue = cardList[i];
			}
		}

		Console.WriteLine(count);
	}
}
