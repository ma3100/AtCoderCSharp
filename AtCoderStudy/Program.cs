using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public class Point
	{
		public int start { get; set; }
		public int end { get; set; }
	}

	static void Main(string[] args)
	{
		var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		var S = Console.ReadLine();
		var zeroStartList = new Dictionary<int,Point>();
		var flag = true;
		var index = 0;		

		for (int i = 0; i < S.Length; i++)
		{
			if (flag)
			{
				if (S[i] == '0')
				{
					zeroStartList.Add(index,new Point() { start = i});
					flag = false;
				}
			}
			else
			{
				if (S[i] == '1')
				{
					flag = true;
					zeroStartList[index].end = i;
					index++;
				}
			}
		}
		var retsu = 0;
		if(zeroStartList.Any() && zeroStartList.Count() > array[1])
		{
			for(int i = 0; i <= zeroStartList.Count() -array[1];i++)
			{
				var sakadatiCount = 0;
				var menjoList = new List<Point>();
				for(int y = 0;y < array[1];y++)
				{
					menjoList.Add(zeroStartList[i + y]);
				}

				var menjoIndex = 0;
				var menjoFlag = false;
				for(int z = 0;z < array[0];z++)
				{
					if(S[z] == '1' )
					{
						if (menjoFlag)
						{
							menjoFlag = false;
							if(menjoIndex < array[1] -1)
								menjoIndex++;
						}
						sakadatiCount++;
					}
					else if (z >= menjoList[menjoIndex].start && z < menjoList[menjoIndex].end)
					{
						sakadatiCount++;
						menjoFlag = true;
					}
					else
					{
						if (sakadatiCount > retsu)
						{
							retsu = sakadatiCount;
						}
						sakadatiCount = 0;
					}
				}
				if (sakadatiCount > retsu)
				{
					retsu = sakadatiCount;
				}
			}
		}
		else
		{
			retsu = array[0];
		}
		Console.WriteLine(retsu);
	}
}
