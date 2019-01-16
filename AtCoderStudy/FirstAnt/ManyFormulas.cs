using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class ManyFormulas
	{
		List<string> bitList = new List<string>();
		int inputLength = 0;

		public void Do()
		{
			// 文字列の入力
			var s = Console.ReadLine();
			var inputLength = s.Length;

			makeBitList(0, "");
			var answer = bitList.Select(x => int.Parse(x) * int.Parse(s)).Sum();
		}

		private void makeBitList(int count,string bit)
		{
			if(count == inputLength)
			{
				bitList.Add(bit);
			}
			else
			{
				makeBitList(++count, bit + "0");
				makeBitList(++count, bit + "1");
			}
		}
	}
}
