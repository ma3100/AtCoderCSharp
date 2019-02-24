using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
class Z { static void Main() => new K(); }
class K
{
	int F => int.Parse(Str);
	long FL => long.Parse(Str);
	int[] G => Strs.Select(int.Parse).ToArray();
	long[] GL => Strs.Select(long.Parse).ToArray();
	string Str => ReadLine();
	string[] Strs => Str.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
	const int MOD = 998244353;
	public K()
	{
		SetOut(new StreamWriter(OpenStandardOutput()) { AutoFlush = false });
		WriteLine(Solve());
		Out.Flush();
	}
	Random rand = new Random();
	long Solve()
	{
		var I = G;
		int Y = I[0], X = I[1];
		var mat = new bool[Y][];
		for (var y = 0; y < Y; y++)
		{
			mat[y] = new bool[X];
			I = G;
			for (var x = 0; x < X; x++) mat[y][x] = I[x] != 0;
		}
		var r = 0;
		for (var c = 0; c < X; c++)
		{
			int y = r;
			while (y < Y && !mat[y][c]) y++;
			if (y == Y) continue;
			if (y != r) AddTo(mat[r], mat[y]);
			for (y = r + 1; y < Y; y++) if (mat[y][c]) AddTo(mat[y], mat[r]);
			r++;
		}
		return (Pow(2, X + Y - 1, MOD) - Pow(2, X + Y - r - 1, MOD) + MOD) % MOD;
	}
	void Print(bool[] a) => WriteLine(string.Join("", a.Select(b => b ? 1 : 0)));
	public static long Pow(long a, long b, long mod)
	{
		var p = 1L;
		var x = a;
		while (b > 0)
		{
			if ((b & 1) == 1) p = (p * x) % mod;
			b >>= 1;
			x = (x * x) % mod;
		}
		return p;
	}
	// a += b
	void AddTo(bool[] a, bool[] b)
	{
		var n = a.Length;
		for (var i = 0; i < n; i++) a[i] = a[i] ^ b[i];
	}
}
