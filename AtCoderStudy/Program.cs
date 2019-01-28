using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

	static char[,] A = new char[5, 5]; // 盤面の情報
	static int[,] b = new int[5, 5];// 得点の情報1
	static int[,] c = new int[5, 5]; // 得点の情報2

	public static void Main(string[] args)
	{
		// 入力
		int sum = 0; // 全体の合計
		for (int i = 0; i < 2; i++)
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			for (int j = 0; j < 3; j++)
			{
				b[i, j] = input[j];
				sum += b[i, j];
			}
		}
		for (int i = 0; i < 3; i++)
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			for (int j = 0; j < 2; j++)
			{
				c[i, j] = input[j];
				sum += c[i, j];
			}
		}

		// 盤面を全て'*'で初期化
		for (int x = 0; x < 5; x++)
		{
			for (int y = 0; y < 5; y++)
			{
				A[x, y] = '*';
			}
		}

		int answer = dfs(0); // 直大の得点が返ってくる
		Console.WriteLine(answer);
		Console.WriteLine(sum - answer);
	}

	// 盤面を全通りに埋めるDFS
	static int dfs(int turn)
	{
		if (turn == 9) return calc();

		if (turn % 2 == 0)
		{
			int Max = -1;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (A[i, j] != '*') continue;
					A[i, j] = 'o'; // 盤面に'o'を打つ
					Max = Math.Max(Max, dfs(turn + 1));
					A[i, j] = '*'; // 盤面を元に戻す
				}
			}
			return Max;
		}
		else
		{
			int Min = 1;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (A[i, j] != '*') continue;
					A[i, j] = 'x'; // 盤面に'x'を打つ
					Min = Math.Min(Min, dfs(turn + 1));
					A[i, j] = '*'; // 盤面を元に戻す
				}
			}
			return Min;
		}
	}

	// 盤面を埋め終わったとき、直大の得点を返す
	static int calc()
	{
		int score = 0;
		// b[2][3]についての直大の得点
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				if (A[i, j] == A[i + 1, j]) score += b[i, j];
			}
		}
		// c[3][2]についての直大の得点
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				if (A[i, j] == A[i, j + 1]) score += c[i, j];
			}
		}
		return score;
	}
}

