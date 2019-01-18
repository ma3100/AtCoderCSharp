using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static System.Console;
using static System.Convert;
using static System.Math;

class Program
{
	class P
	{
		public int index;
		public List<int> ad;

		public P(int index)
		{
			this.index = index;
			ad = new List<int>();
		}
	}

	static P[] pArray;

	static void Main(string[] args)
	{
		var nm = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
		pArray = new P[nm[0]];
		var set = new HashSet<int>();
		// 各拠点間の関連性をpsにセットする。
		for (var i = 0; i < nm[1]; i++)
		{
			var ab = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
			for (var j = 0; j < 2; j++)
			{
				if (set.Contains(ab[j]))
					pArray[ab[j] - 1].ad.Add(ab[1 - j] - 1);
				else
				{
					set.Add(ab[j]);
					// 1番地点を配列の0番目に入れる等、1ずつズレる。
					pArray[ab[j] - 1] = new P(ab[j] - 1);
					// 要素が2つなので、残りの片方の場所と関連性を持たせる
					pArray[ab[j] - 1].ad.Add(ab[1 - j] - 1);
				}
			}
		}
		set.Clear();
		var result = 0;

		// 始点(0)から何通りあるかだけ調べれば良いので一回だけ呼ぶ
		answer(ref result, set, 0);
		WriteLine(result);
	}

	private static void answer(ref int result, HashSet<int> set, int i)
	{
		// Setで関連性のある物を繋げ続ける。
		set.Add(i);
		for (var j = 0; j < pArray[i].ad.Count; j++)
		{
			// 関連性のある地点がまだセットされてなければ再帰
			if (!set.Contains(pArray[i].ad[j]))
				answer(ref result, set, pArray[i].ad[j]);
		}

		// 繋ぎ続けた結果、全体の大きさと同じになった場合正解
		if (set.Count == pArray.Length) result++;
		set.Remove(i);
	}
}
