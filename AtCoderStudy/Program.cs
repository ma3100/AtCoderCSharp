using System;
using System.Linq;

public class Program
{
	//limit
	static int A, B, C, N;

	static int[] l;

	public static void Main(string[] args)
	{
		// スペース区切りの整数の入力
		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


		var A = input[0] ;
		var B = input[1] ;
		var K = input[2];

		var answer =101;
		var flag = true;
		var counter = 0;
		while (flag)
		{
			answer--;
			var aAnswer = A % answer;
			var bAnswer = B % answer;
			if (aAnswer == 0 & bAnswer == 0)
			{
				counter++;
				if (counter == K)
					flag = false;
			}
		}
		Console.WriteLine(answer);
	}
}
