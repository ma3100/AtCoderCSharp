using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy.FirstAnt
{
	public class DepthFirstSearch
	{
		int H = 0;
		int W = 0;
		int startX = 0;
		int startY = 0;
		new char[,] stageArray = new char[500, 500];
		bool goalFlag = false;

		public void Do()
		{
			// スペース区切りの整数の入力
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			H = input[0];
			W = input[1];
			
			// 迷路の作成
			for(int x = 0; x < H;x++)
			{
				// 迷路の入力
				var raw = Console.ReadLine();
				for(int y = 0; y < W; y++)
				{
					stageArray[x, y] = raw[y];
					// スタート地点の記憶
					if(raw[y] == 's')
					{
						startX = x;
						startY = y;
					}
				}
			}
			SearchRoad();

			if (goalFlag)
				Console.WriteLine("Yes");
			else
				Console.WriteLine("No");
		}

		private void SearchRoad()
		{
			CheckRoad(startX - 1, startY);
			CheckRoad(startX + 1, startY);
			CheckRoad(startX, startY - 1);
			CheckRoad(startX, startY + 1);

		}

		private void CheckRoad(int x, int y)
		{
			// 範囲外
			if (x >= H || y >= W || x < 0 || y < 0)
			{
				return;
			}
			// 壁または既に通った道判定
			if (stageArray[x, y] == '#' || stageArray[x, y] == 'e' || stageArray[x, y] == 's')
			{
				return;
			}
			// goal
			if (stageArray[x, y] == 'g')
			{
				goalFlag = true;
				return;
			}
			if (stageArray[x, y] == '.')
			{
				stageArray[x, y] = 'e';
				CheckRoad(x - 1, y);
				CheckRoad(x + 1, y);
				CheckRoad(x, y - 1);
				CheckRoad(x, y + 1);
			}
		}
	}
}
