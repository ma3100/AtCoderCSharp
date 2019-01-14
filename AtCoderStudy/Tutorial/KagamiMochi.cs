using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.Tutorial
{
	public class KagamiMochi
	{
		public void Do()
		{
			// 整数の入力(入力回数)
			int n = int.Parse(Console.ReadLine());
			var inputList = new List<int>();

			for(int i = 1; i <= n; i++)
			{
				inputList.Add(int.Parse(Console.ReadLine()));
			}

			var answer = inputList.Distinct().Count();
			Console.WriteLine(answer);
		}
	}
}
