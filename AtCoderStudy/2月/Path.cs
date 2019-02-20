using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._2月
{
	public class Path
	{
		public void Do()
		{
			var inputList = new List<int>();

			for(int i = 0;i < 3;i++)
			{
				// スペース区切りの整数の入力
				var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				inputList.Add(input[0]);
				inputList.Add(input[1]);
			}

			var resultGroup = inputList.GroupBy(x => x).Select(x => new { x.Key, Count = x.Count() });
			if (resultGroup.Any(x => x.Count == 3))
				Console.WriteLine("NO");
			else
				Console.WriteLine("YES");
		}
	}
}
