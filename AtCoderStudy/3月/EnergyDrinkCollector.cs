using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class EnergyDrinkCollector
	{
		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

			var N = input[0];
			var M = input[1];

			var shopDic = new Dictionary<long, long>();
			for (int i = 0; i < N; i++)
			{
				input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
				// 既にキーが追加されていたら値だけ追加
				if (shopDic.ContainsKey(input[0]))
				{
					shopDic[input[0]] += input[1];
				}
				else
				{
					shopDic.Add(input[0], input[1]);
				}
			}
			shopDic = shopDic.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

			long answer = 0;
			foreach (KeyValuePair<long, long> pair in shopDic)
			{
				// 次の店に行く必要がない場合
				if (M <= pair.Value)
				{
					answer += pair.Key * M;
					break;
				}
				else
				{
					answer += pair.Key * pair.Value;
					M -= pair.Value;
				}
			}

			Console.WriteLine(answer);
		}
	}
}
