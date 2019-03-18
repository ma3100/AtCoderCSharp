using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

	static void Main(string[] args)
	{
		Console.WriteLine(Solve());
		return;
	}

	public static string Solve()
	{
		long MOD = 1000000007;
		long ans = 0;

		int N = int.Parse(Console.ReadLine());
		string S = Console.ReadLine();

		int[] cnt = new int[27];
		for (int i = 0; i < N; i++)
		{
			cnt[S[i] - 'a']++;
		}
		//Console.WriteLine(string.Join(", ",cnt));
		ans = 1;
		for (int i = 0; i < 27; i++)
		{
			ans = (ans * (cnt[i] + 1)) % MOD;
		}
		ans--;
		return ans.ToString();
	}
}
