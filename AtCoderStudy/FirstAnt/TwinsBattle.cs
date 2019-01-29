using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class TwinsBattle
	{
		static int[][] s = new int[5][];
		static int[] arr = new int[9];
		static int[] tn = new int[9];
		static int ans = 0;
		static int[] b = new int[2];
		static Dictionary<string, int> hs = new Dictionary<string, int>();

		public void Do()
		{
			for (int i = 0; i < 5; i++)
			{
				s[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			}
			for (int i = 0; i < 9; i++) { arr[i] = 2; }
			ans = s[0][0] + s[0][1] + s[0][2] + s[1][0] + s[1][1] + s[1][2] + s[2][0] + s[2][1] + s[3][0] + s[3][1] + s[4][0] + s[4][1];

			for (int i = 0; i < 9; i++)
			{
				if (arr[i] == 2)
				{
					arr[i] = 0;
					Solve(1);
					tn[0] = Math.Max(tn[0], tn[1]);
					arr[i] = 2;
				}
			}

			Console.WriteLine(tn[0]);
			Console.WriteLine(ans - tn[0]);
		}

		static void Solve(int a)
		{
			string key = String.Join("", arr);
			bool c = false;
			if (hs.ContainsKey(key)) { tn[a] = hs[key]; }
			else
			{
				tn[a] = (a & 1) * 10000;
				for (int i = 0; i < 9; i++)
				{
					if (arr[i] == 2)
					{
						arr[i] = a & 1;
						if (a == 8)
						{
							b[0] = 0;
							b[arr[0] ^ arr[3]] += s[0][0]; b[arr[1] ^ arr[4]] += s[0][1]; b[arr[2] ^ arr[5]] += s[0][2];
							b[arr[3] ^ arr[6]] += s[1][0]; b[arr[4] ^ arr[7]] += s[1][1]; b[arr[5] ^ arr[8]] += s[1][2];
							b[arr[0] ^ arr[1]] += s[2][0]; b[arr[1] ^ arr[2]] += s[2][1];
							b[arr[3] ^ arr[4]] += s[3][0]; b[arr[4] ^ arr[5]] += s[3][1];
							b[arr[6] ^ arr[7]] += s[4][0]; b[arr[7] ^ arr[8]] += s[4][1];
							tn[8] = b[0];
						}
						else
						{
							Solve(a + 1);
							if ((a & 1) == 0)
							{
								tn[a] = Math.Max(tn[a], tn[a + 1]);
								if (tn[a] >= tn[a - 1]) { c = true; arr[i] = 2; break; }
							}
							else
							{
								tn[a] = Math.Min(tn[a], tn[a + 1]);
								if (tn[a] <= tn[a - 1]) { c = true; arr[i] = 2; break; }
							}
						}
						arr[i] = 2;
					}
				}
				if (!c) { hs[key] = tn[a]; }
			}
		}


		//char[,] A = new char[5,5]; // 盤面の情報
		//int[,] b = new int[5, 5];// 得点の情報1
		//int[,] c = new int[5, 5]; // 得点の情報2

		//public void Do()
		//{
		//	// 入力
		//	int sum = 0; // 全体の合計
		//	for (int i = 0; i < 2; i++)
		//	{
		//		// スペース区切りの整数の入力
		//		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		//		for (int j = 0; j < 3; j++)
		//		{
		//			b[i,j] = input[j];
		//			sum += b[i,j];
		//		}
		//	}
		//	for (int i = 0; i < 3; i++)
		//	{
		//		// スペース区切りの整数の入力
		//		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		//		for (int j = 0; j < 2; j++)
		//		{
		//			c[i,j] = input[j];
		//			sum += c[i,j];
		//		}
		//	}

		//	// 盤面を全て'*'で初期化
		//	for (int x = 0; x < 5; x++)
		//	{
		//		for (int y = 0; y < 5; y++)
		//		{
		//			A[x, y] = '*';
		//		}
		//	}

		//	int answer = dfs(0); // 直大の得点が返ってくる
		//	Console.WriteLine(answer);
		//	Console.WriteLine(sum = answer);
		//}

		//// 盤面を全通りに埋めるDFS
		//int dfs(int turn)
		//{
		//	if (turn == 9) return calc();

		//	if (turn % 2 == 0)
		//	{ 
		//		int Max = -1;
		//		for (int i = 0; i < 3; i++)
		//		{
		//			for (int j = 0; j < 3; j++)
		//			{
		//				if (A[i,j] != '*') continue;
		//				A[i,j] = 'o'; // 盤面に'o'を打つ
		//				Max = Math.Max(Max, dfs(turn + 1));
		//				A[i,j] = '*'; // 盤面を元に戻す
		//			}
		//		}
		//		return Max;
		//	}
		//	else
		//	{ 
		//		int Min = 1;
		//		for (int i = 0; i < 3; i++)
		//		{
		//			for (int j = 0; j < 3; j++)
		//			{
		//				if (A[i,j] != '*') continue;
		//				A[i,j] = 'x'; // 盤面に'x'を打つ
		//				Min = Math.Min(Min, dfs(turn + 1));
		//				A[i,j] = '*'; // 盤面を元に戻す
		//			}
		//		}
		//		return Min;
		//	}
		//}

		//// 盤面を埋め終わったとき、直大の得点を返す
		//int calc()
		//{
		//	int score = 0;
		//	// b[2][3]についての直大の得点
		//	for (int i = 0; i < 2; i++)
		//	{
		//		for (int j = 0; j < 3; j++)
		//		{
		//			if (A[i,j] == A[i + 1,j]) score += b[i,j];
		//		}
		//	}
		//	// c[3][2]についての直大の得点
		//	for (int i = 0; i < 3; i++)
		//	{
		//		for (int j = 0; j < 2; j++)
		//		{
		//			if (A[i,j] == A[i,j + 1]) score += c[i,j];
		//		}
		//	}
		//	return score;
		//}
	}
}


