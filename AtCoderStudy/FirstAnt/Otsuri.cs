using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class Otsuri
	{
		public void Do()
		{
			// 金額の入力
			var money = int.Parse(Console.ReadLine());
			var otusri = 1000 - money;
			var num = 0;

			CheckCoinNum(500,ref otusri, ref num);
			CheckCoinNum(100, ref otusri, ref num);
			CheckCoinNum(50, ref otusri, ref num);
			CheckCoinNum(10, ref otusri, ref num);
			CheckCoinNum(1, ref otusri, ref num);

			Console.WriteLine(num);
		}

		private static void CheckCoinNum(int coinValue, ref int otusri, ref int num)
		{
			while (otusri >= coinValue)
			{
				otusri = otusri - coinValue;
				num++;
			}
		}
	}
}
