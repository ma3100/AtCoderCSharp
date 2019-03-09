using System;
using System.Linq;

public class Program
{

	public static void Main(string[] args)
	{
		var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
		var result = input[0];
		for(long i = input[0] + 1; i <=input[1];i++)
		{
			result = result ^ i;
		}
		Console.WriteLine(result);
	}
}
