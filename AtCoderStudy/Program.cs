using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static List<string> bitList = new List<string>();
	static int inputLength = 0;
	static List<int> answerList = new List<int>();


	static void Main(string[] args)
	{
		inputLength = int.Parse(Console.ReadLine());
		// スペース区切りの整数の入力
		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

		// ビットリストを作る
		makeBitList(0, "");
		foreach (var bit in bitList)
		{
			var answer = getAnswer(bit, input);
			answerList.Add(answer);
		}
		Console.WriteLine(answerList.Distinct().Count());
	}

	private static int getAnswer(string bit, int[] input)
	{
		var answer = 0;

		for (int i = 0; i < bit.Length; i++)
		{
			if (bit[i] == '1')
			{
				answer += input[i];
			}
		}
		return answer;
	}

	private static void makeBitList(int count, string bit)
	{
		if (count == inputLength)
		{
			bitList.Add(bit);
		}
		else
		{
			count += 1;
			makeBitList(count, bit + "0");
			makeBitList(count, bit + "1");
		}
	}

}


