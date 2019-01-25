using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class TrumpSort
	{
		public void Do()
		{
			// TODOインラインDPの習得
			int N = int.Parse(Console.ReadLine());
			var cardList = new int[N];
			for (int i = 0; i < N; i++)
			{
				cardList[i] = int.Parse(Console.ReadLine());
			}

			var count = 0;
			var targetValue = cardList[0];
			for (int i = 1; i < N; i++)
			{
				if (cardList[i] < targetValue)
				{
					count++;
				}
				else
				{
					targetValue = cardList[i];
				}
			}

			Console.WriteLine(count);

			//for (int i = 1; i < N; i++)
			//{
			//	if(cardList[i] < cardList[i-1])
			//	{
			//		var flag = true;
			//		var counter = 1;
			//		while(flag)
			//		{
			//			// 1つ目と二つ目の要素が違う時
			//			if(i == 1)
			//			{
			//				var lowValue = cardList[i];
			//				var upValue = cardList[i - 1];
			//				cardList[i] = lowValue;
			//				cardList[i - 1] = upValue;

			//			}
			//		}
			//	}
			//}

		}
	}
}
