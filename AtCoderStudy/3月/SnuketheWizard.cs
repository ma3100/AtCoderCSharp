using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._3月
{
	public class SnuketheWiza1rd
	{
		private class Position
		{
			public char address { get; set; }
			public int count { get; set; }
		}

		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var N = input[0];
			var Q = input[1];

			var S = Console.ReadLine();

			var targetDictionary = new Dictionary<int, Position>();
			for(int i = 0;i < N; i++)
			{
				targetDictionary.Add(i, new Position() { address = S[i], count = 1 });
			}				

			for(int i = 0;i < Q; i++)
			{
				// スペース区切りの文字列の入力
				var motion = Console.ReadLine().Split(' ').ToArray();
				var targetIndexList = targetDictionary.Where(x => x.Value.address.ToString() == motion[0]).ToList();

				var deleteNum = motion[1] == "R" ? N - 1 : 0;
				var slideValue = motion[1] == "R" ? 1 : -11;

				foreach(var target in targetIndexList)
				{
					targetDictionary[target.Key].count = 0;
					if(target.Key != deleteNum)
						targetDictionary[target.Key + slideValue].count = 0;
				}
				foreach (var target in targetIndexList)
				{
					if (target.Key != deleteNum)
						targetDictionary[target.Key + slideValue].count = target.Value.count;
				}
			}

			var result = targetDictionary.Count(x => x.Value.count != 0);
			Console.WriteLine(result);

		}
	}
}
