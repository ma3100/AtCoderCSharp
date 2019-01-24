using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	struct ItemInfoDef
	{
		internal long Omosa;
		internal long Val;
	}

	static List<ItemInfoDef> ItemList = new List<ItemInfoDef>();

	struct JyoutaiDef
	{
		internal int CurrP;
		internal long OmosaSum;
		internal long SumVal;
		internal List<ItemInfoDef> SelectedItemList;
	}

	//重さ合計の制限
	static long OmosaSumLimit = 0;

	static void Main()
	{
		// スペース区切りの整数の入力
		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		var N = input[0];
		OmosaSumLimit = input[1];

		for(int i = 0;i < N;i++)
		{
			// スペース区切りの整数の入力
			var itemArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			ItemList.Add(new ItemInfoDef() {  Val = itemArray[0], Omosa = itemArray[1] });
		}


		var JyoutaiDefList = new List<JyoutaiDef>();
		var stk = new Stack<JyoutaiDef>();
		for (int I = 0; I <= ItemList.Count - 1; I++)
		{
			JyoutaiDef WillPush;
			WillPush.CurrP = I;
			WillPush.OmosaSum = ItemList[I].Omosa;
			WillPush.SumVal = ItemList[I].Val;
			WillPush.SelectedItemList = new List<ItemInfoDef>() { ItemList[I] };
			stk.Push(WillPush);
		}

		while (stk.Count > 0)
		{
			JyoutaiDef Popped = stk.Pop();
			JyoutaiDefList.Add(Popped);

			for (int I = Popped.CurrP + 1; I <= ItemList.Count - 1; I++)
			{
				JyoutaiDef WillPush;
				WillPush.CurrP = I;
				WillPush.OmosaSum = Popped.OmosaSum + ItemList[I].Omosa;
				WillPush.SumVal = Popped.SumVal + ItemList[I].Val;
				WillPush.SelectedItemList = new List<ItemInfoDef>(Popped.SelectedItemList);
				WillPush.SelectedItemList.Add(ItemList[I]);

				if (WillPush.OmosaSum <= OmosaSumLimit) stk.Push(WillPush);
			}
		}

		long MaxSumVal = JyoutaiDefList.Max(X => X.SumVal);
		JyoutaiDef AnswerJyoutai = JyoutaiDefList.First(X => X.SumVal == MaxSumVal);

		Console.WriteLine(MaxSumVal);

		//Console.WriteLine("深さ優先探索の結果を表示します。");
		//Console.WriteLine("重さ合計が{0}以下での最大の価値は、", OmosaSumLimit);
		//Console.WriteLine("重さ合計={0}で価値合計={1}です。", AnswerJyoutai.OmosaSum, MaxSumVal);
		//Console.WriteLine();
		//Console.WriteLine(new string('■', 30));
		//Console.WriteLine("選択した荷物の情報を表示します。");

		//foreach (ItemInfoDef EachItem in AnswerJyoutai.SelectedItemList)
		//{
		//	Console.WriteLine("重さ={0}、価値={1}",
		//		EachItem.Omosa, EachItem.Val);
		//}
	}
}
