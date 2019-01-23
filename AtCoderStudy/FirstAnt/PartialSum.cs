using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class PartialSum
	{
		List<string> bitList = new List<string>();
		int inputLength = 0;
		List<int> answerList = new List<int>();

		public void Do()
		{
			inputLength = int.Parse(Console.ReadLine());
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			// ビットリストを作る
			makeBitList(0, "");
			foreach(var bit in bitList)
			{
				var answer = getAnswer(bit,input);
				answerList.Add(answer);
			}
			Console.WriteLine(answerList.Distinct().Count());
		}

		private int getAnswer(string bit,int[] input)
		{
			var answer = 0;

			for(int i=0;i<bit.Length;i++)
			{
				if(bit[i] == '1')
				{
					answer += bit[i];
				}
			}
			return answer;
		}

		private void makeBitList(int count, string bit)
		{
			if (count == inputLength)
			{
				bitList.Add(bit);
			}
			else
			{
				count += 1;
				makeBitList(count, bit + "0");
				makeBitList(count, bit + "1");
			}
		}

	}
}
