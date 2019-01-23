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
		string str = "";
		double ans = 0;


		public void Do()
		{
			// 文字列の入力
			str = Console.ReadLine();
			inputLength = str.Length;			

			makeBitList(0, "");
			var answer = bitList.Select(x => int.Parse(x) * int.Parse(str)).Sum();
		}

		private void makeBitList(int count, string bit)
		{
			if (count == inputLength - 1)
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

		public void keisan(string s)
		{
			string str2 = "";
			char[] nums = str.ToCharArray();
			char[] c = s.ToCharArray();

			str2 += nums[0].ToString();

			for (int i = 0; i < c.Length; i++)
			{
				if (c[i] == '1')
				{

					ans += double.Parse(str2);
					str2 = "";
				}
				str2 += nums[i + 1].ToString();
			}

			ans += double.Parse(str2);
		}
	}
}
